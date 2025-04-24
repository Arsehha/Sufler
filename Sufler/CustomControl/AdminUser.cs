using Sufler.Forms;
using Sufler.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Sufler.CustomControl
{
    public partial class AdminUser : System.Windows.Forms.UserControl
    {
        private user _user;
        private Guid _id;

        public AdminUser()
        {
            InitializeComponent();
        }

        public AdminUser(user user, Guid id)
        {
            InitializeComponent();
            _user = user;
            FillRoleComboBox(); // Заполнение ComboBox для выбора роли
            FillUserDetails();  // Заполнение имени пользователя при инициализации
            _id = id;
        }

        // Метод для заполнения имени пользователя
        private void FillUserDetails()
        {
            if (_user != null)
            {
                label1.Text = $"{_user.first_name} {_user.last_name}"; // Предполагается, что у тебя есть label для имени
                comboBox1.SelectedItem = _user.role; // Устанавливаем текущую роль пользователя в ComboBox
            }
        }

        // Метод для загрузки ролей в ComboBox
        private void FillRoleComboBox()
        {
            comboBox1.Items.Clear();
            // Предположим, что роли могут быть "User", "Admin"
            comboBox1.Items.Add("user");
            comboBox1.Items.Add("admin");
        }

        // Обработчик изменения роли пользователя через ComboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_user != null)
            {
                var selectedRole = comboBox1.SelectedItem.ToString();
                if (_user.role != selectedRole)
                {
                    // Обновление роли пользователя в базе данных
                    using (var db = new SuflerDB())
                    {
                        var userToUpdate = db.users.FirstOrDefault(u => u.user_id == _user.user_id);
                        if (userToUpdate != null)
                        {
                            userToUpdate.role = selectedRole;
                            db.SaveChanges();
                            MessageBox.Show($"Роль пользователя {_user.first_name} {_user.last_name} изменена на {selectedRole}.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        // Обработчик для кнопки удаления пользователя
        private void buttonDel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Вы уверены, что хотите удалить этого пользователя?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                using (var db = new SuflerDB())
                {
                    var userToDelete = db.users.FirstOrDefault(u => u.user_id == _user.user_id);
                    if (userToDelete != null)
                    {
                        // Удаление всех связанных данных: отзывы, отклики, проекты и т.д.
                        db.reviews.RemoveRange(db.reviews.Where(r => r.reviewer == userToDelete.user_id || r.recepient == userToDelete.user_id));
                        db.responses.RemoveRange(db.responses.Where(r => r.id_user == userToDelete.user_id));
                        db.participants.RemoveRange(db.participants.Where(p => p.id_user == userToDelete.user_id));
                        db.projects.RemoveRange(db.projects.Where(p => p.creator == userToDelete.user_id));

                        // Удаление пользователя
                        db.users.Remove(userToDelete);
                        db.SaveChanges();
                        MessageBox.Show($"Пользователь {_user.first_name} {_user.last_name} был успешно удалён.", "Удаление завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Очистка управления
                        this.Dispose(); // Удаляет текущий контрол из родительской формы
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден в базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AdminUser_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(_id, _user.user_id);
            profileForm.ShowDialog();
        }
    }
}
