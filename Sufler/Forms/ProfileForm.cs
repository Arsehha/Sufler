using Sufler.Models;
using Sufler.Properts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sufler.Forms
{
    public partial class ProfileForm : ParentForm
    {

        private user _profile, _otherProfile;
        private bool _owner = false;
        private string type = null;
        private SuflerDB context = new SuflerDB();
        private review[] reviews = new review[0];
        public ProfileForm()
        {
            InitializeComponent();
        }

        public ProfileForm(Guid profile, Guid uuid)
        {
            InitializeComponent();
            Drawer.MakeControlRound(pictureBoxAvatar, 4);
            load(profile, uuid);
        }

        private void load(Guid profile, Guid uuid)
        {
            using (var ctx = new SuflerDB())
            {
                _otherProfile = ctx.users.FirstOrDefault(u => u.user_id == uuid);
                _profile = ctx.users.FirstOrDefault(u => u.user_id == profile);
            }

            string name = $"{_otherProfile.first_name} {_otherProfile.last_name}";
            this.Text = $"Профиль {name}";

            labelName.Text = name ;

            if (_profile.user_id == _otherProfile.user_id)
            {
                _owner = true;
                buttonOtzev.Enabled = false;
                buttonOtzev.Visible = false;
            }
            else 
            {
                buttonChangeInfo.Enabled = false;
                buttonChangeInfo.Visible = false;
                buttonDel.Enabled = false;
                buttonDel.Visible = false;
            }
        }

        private void roundedButtonInfo_Click(object sender, EventArgs e)
        {
            panelOtzev.Visible = false;
            panelInfo.Visible = true;
            fillInfo();
        }

        private void roundedButtonOtzev_Click(object sender, EventArgs e)
        {
            panelOtzev.Visible = true;
            panelInfo.Visible = false;
        }

        //Смена типа отзывов
        private void radioButtonIsp_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonIsp.Checked)
            {
                type = "executor"; // или "ispolnitel"
                GetReview(type);
            }
        }

        //Получение списка отзывов
        private void GetReview(string type)
        {
            if (_otherProfile == null) return;

            using (var newContext = new SuflerDB())
            {
                reviews = newContext.reviews
                    .Where(r => r.recepient == _otherProfile.user_id && r.type == type)
                    .OrderByDescending(r => r.date_created)
                    .ToArray();

                flowLayoutPanel1.Controls.Clear();

                foreach (var rev in reviews)
                {
                    var control = new Sufler.CustomControl.Review(rev);
                    control.Dock = DockStyle.Top;
                    flowLayoutPanel1.Controls.Add(control);
                }

                //Средняя оценка
                if (reviews.Length > 0)
                {
                    double avg = reviews.Average(r => r.rate);
                    labelBall.Text = $"Средняя оценка: {avg:F1}";
                }
                else
                {
                    labelBall.Text = "Отзывов нет";
                }
            }
        }


        //Оставление или изменение отзыва
        private void buttonOtzev_Click(object sender, EventArgs e)
        {
            CreateReview reviewForm = new CreateReview(_profile.user_id, _otherProfile.user_id, type);
            var result = reviewForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                GetReview(type); // обновление после сохранения
            }
        }

        //Смена типа отзывов
        private void radioButtonZakaz_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonZakaz.Checked)
            {
                type = "customer"; // или "zakazchik" — зависит от того, как в БД
                GetReview(type);
            }
        }
        
        //Заполнение информации о пользователе
        private void fillInfo()
        {
            load(_profile.user_id, _otherProfile.user_id);

            labelPhone.Text = $"Телефон: {_otherProfile.phone}";
            labelDate.Text = $"Дата рождения: {_otherProfile.date_birth.ToShortDateString()}";
            labelDateCreate.Text = $"Дата создания: {_otherProfile.date_created.ToShortDateString()}";
            textBoxInfo.Text = _otherProfile.bio;
        }

        //Удаление пользователя
        private void DeleteProfile(Guid userId)
        {
            
                using (var context = new SuflerDB())
                {
                    using (var transaction = context.Database.BeginTransaction())
                    {
                        try
                        {
                            // Удаляем отклики (response)
                            var responses = context.responses.Where(r => r.id_user == userId).ToList();
                            context.responses.RemoveRange(responses);

                            // Удаляем участников (participant)
                            var participants = context.participants.Where(p => p.id_user == userId).ToList();
                            context.participants.RemoveRange(participants);

                            // Удаляем отзывы (review) — как автор и как получатель
                            var reviewsSent = context.reviews.Where(r => r.reviewer == userId).ToList();
                            var reviewsReceived = context.reviews.Where(r => r.recepient == userId).ToList();
                            context.reviews.RemoveRange(reviewsSent);
                            context.reviews.RemoveRange(reviewsReceived);

                            // Удаляем проекты пользователя (если он автор)
                            var projects = context.projects.Where(p => p.creator == userId).ToList();
                            context.projects.RemoveRange(projects);

                            // Удаляем пользователя
                            var user = context.users.FirstOrDefault(u => u.user_id == userId);
                            if (user != null)
                                context.users.Remove(user);

                            context.SaveChanges();
                            transaction.Commit();

                           MessageBox.Show("Профиль успешно удалён.");
                           this.DialogResult = DialogResult.OK;
                           this.Close();

                    }
                    catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Ошибка при удалении профиля: {ex.Message}");
                        }
                    }
                }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (!_owner) return;

            var result = MessageBox.Show("Вы уверены, что хотите удалить профиль? Это действие необратимо.",
                                          "Подтверждение удаления",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DeleteProfile(_profile.user_id);
            }
        }

        private void buttonChangeInfo_Click(object sender, EventArgs e)
        {
            if(!_owner) return;

            ChangeAccountInfo reviewForm = new ChangeAccountInfo(_profile.user_id);
            var result = reviewForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                fillInfo();
            }
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            radioButtonZakaz.Checked = true;
            fillInfo();
        }
    }
}
