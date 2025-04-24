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
    public partial class MyJobPanel : System.Windows.Forms.UserControl
    {
        private Guid _user;
        public MyJobPanel()
        {
            InitializeComponent();
        }

        public MyJobPanel(Guid user)
        {
            InitializeComponent();
            _user = user;
        }

        private void MyJobPanel_Load(object sender, EventArgs e)
        {
            using (var db = new SuflerDB())
            {
                // Получаем все project_id, в которых пользователь является участником
                var projectIds = db.participants
                    .Where(p => p.id_user == _user)
                    .Select(p => p.id_project)
                    .Distinct()
                    .ToList();

                // Получаем сами проекты
                var projects = db.projects
                    .Where(p => projectIds.Contains(p.project_id))
                    .ToList();

                if (projects.Count == 0)
                {
                    Label emptyLabel = new Label
                    {
                        Text = "Вы не участвуете ни в одном проекте.",
                        AutoSize = true,
                        Font = new Font("Segoe UI", 12, FontStyle.Italic),
                        ForeColor = Color.Gray,
                        Dock = DockStyle.Top,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    Controls.Add(emptyLabel);
                    return;
                }

                // Выводим каждый проект с помощью ProjectItemControl
                foreach (var project in projects)
                {
                    var projectControl = new ProjectItemControl(project, _user, true);

                    flowLayoutPanel1.Controls.Add(projectControl);
                }
            }
        }
    }
}
