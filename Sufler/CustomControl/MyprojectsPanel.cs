using Sufler.Forms;
using Sufler.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sufler.CustomControl
{
    public partial class MyprojectsPanel : System.Windows.Forms.UserControl
    {
        private Guid _user;
        private SuflerDB context;

        public MyprojectsPanel()
        {
            InitializeComponent();
        }

        public MyprojectsPanel(Guid user)
        {
            InitializeComponent();
            _user = user;
            context = new SuflerDB();
            LoadProjects();
        }

        private void MyprojectsPanel_Load(object sender, EventArgs e)
        {
            LoadProjects();
        }

        private void LoadProjects()
        {
            // Получаем проекты для указанного пользователя
            var userProjects = context.projects.Where(p => p.creator == _user).ToList();

            // Очистить текущие элементы управления, если они есть
            flowLayoutPanel1.Controls.Clear();

            if (userProjects.Any())
            {
                // Если проекты есть, добавляем их на панель
                foreach (var project in userProjects)
                {
                    ProjectItemControl proj = new ProjectItemControl(project, _user);

                    // Добавляем проект в панель
                    flowLayoutPanel1.Controls.Add(proj);
                }
            }
            else
            {
                // Если проектов нет, выводим сообщение
                var noProjectsLabel = new Label
                {
                    Text = "У вас нет проектов.",
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Italic),
                    ForeColor = Color.Gray
                };

                // Добавляем метку с сообщением в панель
                flowLayoutPanel1.Controls.Add(noProjectsLabel);
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            createProject createProject = new createProject(_user);
            var result = createProject.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadProjects();
            }
        }
    }
}
