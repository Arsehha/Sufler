using Sufler.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sufler.Forms
{
    public partial class ChangeAccountInfo : Form
    {
        Guid _user;
        public ChangeAccountInfo(Guid user)
        {
            InitializeComponent();
            _user = user;
            date_birthDateTimePicker.MaxDate = DateTime.Now.AddYears(-14);
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sufler_MironovDataSet);

        }

        private void ChangeAccountInfo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sufler_MironovDataSet.user". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.sufler_MironovDataSet.user);
            passwordTextBox.Clear();

        }

        private bool IsPhoneNumberExist(string phoneNumber)
        {
            using (var context = new SuflerDB())
            {
                var existingUser = context.users.FirstOrDefault(u => u.phone == phoneNumber);
                return existingUser != null;  // Если пользователь найден, возвращаем true
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(first_nameTextBox.Text) || string.IsNullOrEmpty(last_nameTextBox.Text) ||
                string.IsNullOrEmpty(phoneMaskedTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            if (first_nameTextBox.Text.Length < 4 || first_nameTextBox.Text.Length > 15)
            {
                MessageBox.Show("Имя должно быть длинной от 4  до 15 символов.");
                return;
            }

            if (last_nameTextBox.Text.Length < 4 || last_nameTextBox.Text.Length > 15)
            {
                MessageBox.Show("Фамилия должна быть длинной от 4  до 15 символов.");
                return;
            }

            if (IsPhoneNumberExist(phoneMaskedTextBox.Text))
            {
                MessageBox.Show("Пользователь с таким номером телефона уже существует.");
                return;
            }

            int age = DateTime.Now.Year - date_birthDateTimePicker.Value.Year;
            if (date_birthDateTimePicker.Value > DateTime.Now.AddYears(-age)) age--;
            if (age < 14)
            {
                MessageBox.Show("Вам должно быть не менее 14 лет.");
                return;
            }


            using (var context = new SuflerDB())
            {
                var existingUser = context.users.FirstOrDefault(u => u.user_id == _user);
                if (existingUser == null)
                {
                    MessageBox.Show("Пользователь не найден.");
                    return;
                }

                // Обновление данных
                existingUser.first_name = first_nameTextBox.Text.Trim();
                existingUser.last_name = last_nameTextBox.Text.Trim();
                existingUser.date_birth = date_birthDateTimePicker.Value.Date;
                existingUser.phone = phoneMaskedTextBox.Text.Trim();
                existingUser.bio = string.IsNullOrWhiteSpace(bioTextBox.Text) ? null : bioTextBox.Text.Trim();

                if (!string.IsNullOrWhiteSpace(passwordTextBox.Text))
                {
                    if (passwordTextBox.Text.Length < 8 || passwordTextBox.Text.Length > 20)
                    {
                        MessageBox.Show("Пароль должен содержать от 8 до 20 символов.");
                        return;
                    }

                    existingUser.password = HashPassword(passwordTextBox.Text);
                }

                // Сохраняем
                context.SaveChanges();

                MessageBox.Show("Изменения сохранены успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close(); // или перезагрузка данных
            }

        }

        public string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
