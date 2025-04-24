using Sufler.Forms;
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

namespace Sufler.CustomControl
{
    public partial class AdminProjectItem : System.Windows.Forms.UserControl
    {
        private project _project;
        private Guid _guid;
        public AdminProjectItem()
        {
            InitializeComponent();
        }

        public AdminProjectItem(project project, Guid user)
        {
            InitializeComponent();
            _project = project;
            _guid = user;
            load();
        }

        private void AdminProjectItem_Load(object sender, EventArgs e)
        {

        }

        private void load()
        {
            labelNameProj.Text = _project.project_name;
            labelDateEnd.Text = _project.date_end.ToShortDateString();
            labelPrice.Text = $"{_project.price.ToString()} руб.";

            using (var context = new SuflerDB())
            {
                var tagName = context.tags
                    .Where(t => t.tag_id == _project.tags)
                    .Select(t => t.tag_name)
                    .FirstOrDefault();

                labelTagProj.Text = tagName ?? "Без тега";

                // Получаем актуальное состояние из базы
                var projectFresh = context.projects.FirstOrDefault(p => p.project_id == _project.project_id);
                if (projectFresh != null)
                {
                    _project._checked = projectFresh._checked;
                }
            }

            UpdatePublishButton();
        }

        private void UpdatePublishButton()
        {
            if ((bool)_project._checked)
            {
                buttonPush.Text = "Снять";
                buttonPush.BackColor = Color.IndianRed;
            }
            else
            {
                buttonPush.Text = "Опубликовать";
                buttonPush.BackColor = Color.LightGreen;
            }
        }


        private void AdminProjectItem_Click(object sender, EventArgs e)
        {
            ProjectForm projectForm = new ProjectForm(_project, _guid);
            projectForm.Show();
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            using (var context = new SuflerDB())
            {
                var project = context.projects.FirstOrDefault(p => p.project_id == _project.project_id);
                if (project != null)
                {
                    project._checked = !project._checked;
                    context.SaveChanges();

                    MessageBox.Show((bool)project._checked ? "Проект опубликован." : "Проект снят с публикации.");
                    this.Dispose(); 
                }
                else
                {
                    MessageBox.Show("Проект не найден.");
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
                        .Include("responses")
                        .Include("participants")
                        .FirstOrDefault(p => p.project_id == _project.project_id);

                    if (projectToDelete != null)
                    {
                        context.responses.RemoveRange(projectToDelete.responses);
                        context.participants.RemoveRange(projectToDelete.participants);
                        context.projects.Remove(projectToDelete);
                        context.SaveChanges();

                        MessageBox.Show("Проект удалён.");
                        this.Dispose(); // Удалить из интерфейса
                    }
                    else
                    {
                        MessageBox.Show("Проект не найден.");
                    }
                }
            }
        }

    }
}
