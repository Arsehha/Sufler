using Sufler.Forms;
using Sufler.Models;
using Sufler.Properts;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sufler.CustomControl
{
    public partial class UserParticipantItem : System.Windows.Forms.UserControl
    {
        private participant _participant;
        private Guid _currentUserId;
        private bool _isOwner = false;

        public UserParticipantItem()
        {
            InitializeComponent();
        }

        public UserParticipantItem(participant participant, Guid currentUserId)
        {
            InitializeComponent();
            Drawer.MakeControlRound(pictureBox1, 4);
            _participant = participant;
            _currentUserId = currentUserId;

            using (var db = new SuflerDB())
            {
                var project = db.projects.FirstOrDefault(p => p.project_id == _participant.id_project);
                if (project != null && project.creator == _currentUserId)
                {
                    _isOwner = true;
                }
            }

            buttonDel.Visible = _isOwner;
            buttonDel.Enabled = _isOwner;
        }

        private void UserParticipantItem_Load(object sender, EventArgs e)
        {
            using (var db = new SuflerDB())
            {
                var user = db.users.FirstOrDefault(u => u.user_id == _participant.id_user);
                if (user != null)
                {
                    label1.Text = $"{user.first_name} {user.last_name}";
                }
                else
                {
                    label1.Text = "Пользователь не найден";
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Удалить участника из проекта?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                using (var db = new SuflerDB())
                {
                    var participantToRemove = db.participants
                        .FirstOrDefault(p => p.participant_id == _participant.participant_id);
                    if (participantToRemove != null)
                    {
                        db.participants.Remove(participantToRemove);
                        db.SaveChanges();
                        MessageBox.Show("Участник удалён.");
                        this.Dispose(); // Удаляем элемент из интерфейса
                    }
                    else
                    {
                        MessageBox.Show("Участник не найден.");
                    }
                }
            }
        }

        private void UserParticipantItem_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(_currentUserId, _participant.id_user);
            profileForm.ShowDialog();
        }
    }
}