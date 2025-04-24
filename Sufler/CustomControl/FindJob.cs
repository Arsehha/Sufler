using Sufler.Models;
using System;
using System.Data.Entity; // Важно для Include
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sufler.CustomControl
{
    public partial class FindJob : System.Windows.Forms.UserControl
    {
        private user _user;
        private string _selectedTag = "Все";

        public FindJob()
        {
            InitializeComponent();
        }

        public FindJob(user user)
        {
            InitializeComponent();
            _user = user;
        }

        private void FindJob_Load(object sender, EventArgs e)
        {
            LoadTags();
        }

        private void LoadTags()
        {
            using (var context = new SuflerDB())
            {
                flowLayoutPanelTag.Controls.Clear();

                AddTagButton("Все"); // Первая кнопка — Все

                var tags = context.tags.OrderBy(t => t.tag_name).ToList();
                foreach (var tag in tags)
                {
                    AddTagButton(tag.tag_name);
                }

                LoadProjects(); // Загрузка проектов при загрузке тегов
            }
        }

        private void AddTagButton(string tagName)
        {
            int tagButtonWidth = (flowLayoutPanelTag.Width - 200) / 4; // 4 кнопки в строку + отступы

            var tagButton = new Button
            {
                Text = tagName,
                Width = tagButtonWidth,
                Height = 35,
                Margin = new Padding(3),
                FlatStyle = FlatStyle.Flat,
                BackColor = tagName == _selectedTag ? Color.LightBlue : Color.White,
            };

            tagButton.Click += (s, e) =>
            {
                _selectedTag = tagName;
                UpdateTagButtonStyles();
                LoadProjects();
            };

            flowLayoutPanelTag.Controls.Add(tagButton);
        }


        private void UpdateTagButtonStyles()
        {
            foreach (Button btn in flowLayoutPanelTag.Controls)
            {
                btn.BackColor = btn.Text == _selectedTag ? Color.LightBlue : Color.White;
            }
        }

        private void LoadProjects()
        {
            using (var context = new SuflerDB())
            {
                var projectsQuery = context.projects
                    .Include(p => p.tag) // Загрузка связанного тега
                    .Where(p => p._checked == true && p.creator != _user.user_id); // Исключаем свои проекты

                if (_selectedTag != "Все")
                {
                    projectsQuery = projectsQuery
                        .Where(p => p.tag.tag_name == _selectedTag);
                }

                var projects = projectsQuery
                    .OrderByDescending(p => p.date_created)
                    .ToList();

                flowLayoutPanelProject.Controls.Clear();
                foreach (var project in projects)
                {
                    var item = new ProjectItemControl(project, _user.user_id, false);
                    item.Dock = DockStyle.Top;
                    flowLayoutPanelProject.Controls.Add(item);
                }
            }
        }


    }
}
