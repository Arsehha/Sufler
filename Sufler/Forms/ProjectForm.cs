using Sufler.CustomControl;
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

namespace Sufler.Forms
{
    public partial class ProjectForm : ParentForm
    {
        private project _project;
        private Guid _user;
        public ProjectForm()
        {
            InitializeComponent();
        }

        public ProjectForm(project project, Guid user)
        {
            InitializeComponent();
            Drawer.MakeControlRound(pictureBox1, 4);

            _project = project;
            _user = user;

            // Скрыть кнопку, если ты — создатель
            if (_user == _project.creator)
            {
                roundedButtonOtcl.Enabled = false;
                roundedButtonOtcl.Visible = false;
            }
            else
            {
                // Проверка: пользователь уже является участником
                using (var db = new SuflerDB())
                {
                    bool isParticipant = db.participants
                        .Any(p => p.id_project == _project.project_id && p.id_user == _user);

                    if (isParticipant)
                    {
                        roundedButtonOtcl.Enabled = false;
                        roundedButtonOtcl.Visible = false;
                    }
                }
            }
        }

        private void fillPlace()
        {
            if (_project == null) return;

            labelProjectName.Text = _project.project_name;
            this.Text = $"Заказ {_project.project_name}";
            labelDateCreate.Text = $"Дата создания: {_project.date_created.ToShortDateString()}";
            labelDateEnd.Text = $"Дата конца: {_project.date_end.ToShortDateString()}";
            textBoxDesc.Text = _project.description;
            labelPrice.Text = $"{_project.price} руб.";

            using (var db = new SuflerDB())
            {
                // Получаем количество участников
                int participantCount = db.participants
                    .Count(p => p.id_project == _project.project_id);

                // Получаем количество откликов
                int responseCount = db.responses
                    .Count(r => r.id_project == _project.project_id);

                int totalInvolved = participantCount + responseCount;

                labelCount.Text = $"Задействовано людей: {totalInvolved}";

                var user = db.users.FirstOrDefault(u => u.user_id == _project.creator);

                labelZakName.Text = $"{user.first_name} {user.last_name}";

                var reviews = db.reviews
                    .Where(r => r.recepient == user.user_id && r.type == "customer")
                    .ToArray();

                labelCountReview.Text = $"{reviews.Length} отзывов";

                // Загрузка участников проекта
                var participants = db.participants
                    .Where(p => p.id_project == _project.project_id)
                    .ToList();

                flowLayoutPanel1.Controls.Clear();  // Очистим старые элементы в FlowLayoutPanel

                foreach (var participant in participants)
                {
                        // Создаем пользовательский элемент для отображения участника
                        var userParticipantItem = new UserParticipantItem(participant, _user, false);

                        // Добавляем созданный элемент в FlowLayoutPanel
                        flowLayoutPanel1.Controls.Add(userParticipantItem);
                }
            }
        }




        private void ProjectForm_Load(object sender, EventArgs e)
        {
            fillPlace();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            ResponseForm responseForm = new ResponseForm(_project, _user);
            responseForm.ShowDialog();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(_user, _project.creator );
            profileForm.ShowDialog();
        }
    }
}
