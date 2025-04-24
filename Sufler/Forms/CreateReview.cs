using Sufler.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sufler.Forms
{
    public partial class CreateReview : Form
    {
        private Guid _reviewer;
        private Guid _recepient;
        private string _type;
        public CreateReview(Guid reviewer, Guid recepient, string type)
        {
            InitializeComponent();
            _reviewer = reviewer;
            _recepient = recepient;
            _type = type;
        }

        private void reviewBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reviewBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sufler_MironovDataSet);

        }

        private void CreateReview_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new SuflerDB())
                {
                    // Проверяем наличие существующего отзыва
                    var existingReview = context.reviews.FirstOrDefault(r =>
                        r.reviewer == _reviewer &&
                        r.recepient == _recepient &&
                        r.type == _type);

                    if (existingReview != null)
                    {
                        // Автозаполнение
                        rateNumericUpDown.Value = existingReview.rate;
                        textTextBox.Text = existingReview.text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке отзыва: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Сохранение отзыва
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new SuflerDB())
                {
                    // Ищем существующий отзыв
                    var existingReview = context.reviews.FirstOrDefault(r =>
                        r.reviewer == _reviewer &&
                        r.recepient == _recepient &&
                        r.type == _type);

                    if (existingReview != null)
                    {
                        // Обновляем существующий отзыв
                        existingReview.rate = (int)rateNumericUpDown.Value;
                        existingReview.text = textTextBox.Text?.Trim();
                        existingReview.date_created = DateTime.Now;
                    }
                    else
                    {
                        // Создаём новый отзыв
                        var newReview = new review
                        {
                            reviewer = _reviewer,
                            recepient = _recepient,
                            type = _type,
                            rate = (int)rateNumericUpDown.Value,
                            text = textTextBox.Text?.Trim(),
                            date_created = DateTime.Now
                        };

                        context.reviews.Add(newReview);
                    }

                    context.SaveChanges();

                    MessageBox.Show("Отзыв сохранён успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении отзыва: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
