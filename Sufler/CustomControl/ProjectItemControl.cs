using Sufler.Forms;
using Sufler.Models;
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

namespace Sufler.CustomControl
{
    public partial class ProjectItemControl : System.Windows.Forms.UserControl
    {
        private bool _owner = false;
        private project _project;
        private Guid _guid = Guid.Empty;
        private bool is_closed = false;

        public ProjectItemControl()
        {
            InitializeComponent();
        }

        public ProjectItemControl(project project, Guid user)
        {
            InitializeComponent();
            _project = project;
            _guid = user;

            if (_guid == project.creator) 
            {
                _owner = true;
            }

            if (!_owner)
            {
                buttonChange.Enabled = false;
                buttonChange.Visible = false;
                buttonClOp.Enabled = false;
                buttonClOp.Visible = false;
                buttonDel.Enabled = false;
                buttonDel.Visible = false;
            }
            else
            {
                // Показываем кнопку выхода только если пользователь — участник
                using (var context = new SuflerDB())
                {
                    bool isParticipant = context.participants
                        .Any(p => p.id_project == _project.project_id && p.id_user == _guid);

                    buttonBack.Visible = isParticipant;
                    buttonBack.Enabled = isParticipant;
                }

            }

            load();
        }

        private void load()
        {
            labelName.Text = _project.project_name;
            labelDate.Text = _project.date_created.ToShortDateString();
            labelPrice.Text = $"{_project.price.ToString()} руб.";
            using (var context = new SuflerDB())
            {
                var tagName = context.tags
                    .Where(t => t.tag_id == _project.tags)
                    .Select(t => t.tag_name)
                    .FirstOrDefault();

                labelTag.Text = tagName ?? "Без тега";
            }

        }


        private void ProjectItemControl_Load(object sender, EventArgs e)
        {

        }

        private void buttonClOp_Click(object sender, EventArgs e)
        {
            using (var context = new SuflerDB())
            {
                var project = context.projects.FirstOrDefault(p => p.project_id == _project.project_id);
                if (project != null)
                {
                    project.compleated = !project.compleated;
                    context.SaveChanges();

                    _project.compleated = project.compleated;
                    is_closed = (bool)_project.compleated;
                    MessageBox.Show(is_closed? "Проект закрыт." : "Проект открыт.");

                    buttonClOp.Text = is_closed ? "Открыть" : "Закрыть";
                    load();
                }
                else
                {
                    MessageBox.Show("Проект не найден.");
                }
            }
        }


        private void buttonChange_Click(object sender, EventArgs e)
        {
            createProject createProject = new createProject(_guid, _project);
            var result = createProject.ShowDialog();

            if (result == DialogResult.OK)
            {
                using (var context = new SuflerDB())
                {
                    _project = context.projects.FirstOrDefault(p => p.project_id == _project.project_id);
                    load();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите удалить проект?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (var context = new SuflerDB())
                {
                    var projectToDelete = context.projects
                        .Include("responses") // assuming: responses = отклики
                        .Include("participants") // assuming: participants = участники
                        .FirstOrDefault(p => p.project_id == _project.project_id);

                    if (projectToDelete != null)
                    {
                        // Удаляем отклики
                        context.responses.RemoveRange(projectToDelete.responses);

                        // Удаляем участников
                        context.participants.RemoveRange(projectToDelete.participants);

                        // Удаляем сам проект
                        context.projects.Remove(projectToDelete);

                        context.SaveChanges();
                        MessageBox.Show("Проект успешно удалён.");
                        this.Dispose(); // удалить элемент управления из формы
                    }
                    else
                    {
                        MessageBox.Show("Проект не найден.");
                    }
                }
            }
        }

        private void buttonRicipient_Click(object sender, EventArgs e)
        {
            user user;
            using (var context = new SuflerDB())
            {
                user = context.users.FirstOrDefault(u => u.user_id == _guid);
            }
            participantForm participantForm = new participantForm(_project, user );
            participantForm.ShowDialog();
        }

        private void ProjectItemControl_Click(object sender, EventArgs e)
        {
            ProjectForm projectForm = new ProjectForm(_project, _guid);
            projectForm.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Вы уверены, что хотите покинуть проект?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            using (var context = new SuflerDB())
            {
                var participant = context.participants
                    .FirstOrDefault(p => p.id_project == _project.project_id && p.id_user == _guid);

                if (participant != null)
                {
                    context.participants.Remove(participant);
                    context.SaveChanges();
                    MessageBox.Show("Вы покинули проект.");
                    this.Dispose(); // удаление карточки из интерфейса
                }
                else
                {
                    MessageBox.Show("Вы не являетесь участником этого проекта.");
                }
            }
        }

    }
}
