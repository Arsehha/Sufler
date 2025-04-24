using Sufler.Forms;
using Sufler.Models;
using Sufler.Properts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sufler.CustomControl
{
    public partial class UserRequestItem : System.Windows.Forms.UserControl
    {
        private response _response;
        private Guid _guid;
        public UserRequestItem()
        {
            InitializeComponent();
        }

        public UserRequestItem(response response, Guid guid)
        {
            InitializeComponent();
            _response = response;
            Drawer.MakeControlRound(pictureBox1, 4);
            _guid = guid;
        }

        private void UserRecepientItem_Load(object sender, EventArgs e)
        {
            using (SuflerDB db = new SuflerDB())
            {
                var user = db.users.FirstOrDefault(u => u.user_id == _response.id_user);
                labelName.Text = $"{user.first_name} {user.last_name}";
            }
            textBoxMessage.Text = _response.message;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            using (SuflerDB db = new SuflerDB())
            {
                // Проверка на дублирующего участника
                var exists = db.participants.Any(p =>
                    p.id_project == _response.id_project &&
                    p.id_user == _response.id_user);

                if (!exists)
                {
                    // Добавляем участника
                    db.participants.Add(new participant
                    {
                        id_project = _response.id_project,
                        id_user = _response.id_user
                    });
                }

                // Удаляем отклик
                var responseToRemove = db.responses
                    .FirstOrDefault(r => r.response_id == _response.response_id);
                if (responseToRemove != null)
                {
                    db.responses.Remove(responseToRemove);
                }

                db.SaveChanges();
                MessageBox.Show("Пользователь добавлен в участники проекта.");

                this.Dispose(); // Удаляем элемент из интерфейса
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Отклонить отклик?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                using (SuflerDB db = new SuflerDB())
                {
                    var responseToRemove = db.responses
                        .FirstOrDefault(r => r.response_id == _response.response_id);
                    if (responseToRemove != null)
                    {
                        db.responses.Remove(responseToRemove);
                        db.SaveChanges();
                        MessageBox.Show("Отклик отклонён.");
                    }

                    this.Dispose(); // Удаляем элемент из интерфейса
                }
            }
        }

        private void UserRequestItem_Click(object sender, EventArgs e)
        {
            ProfileForm form = new ProfileForm(_guid, _response.id_user);
            form.ShowDialog();
        }
    }
}
