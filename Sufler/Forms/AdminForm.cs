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

namespace Sufler.Forms
{
    public partial class AdminForm : ParentForm
    {
        private Guid _id;

        public AdminForm()
        {
            InitializeComponent();
        }

        public AdminForm(Guid guid)
        {
            InitializeComponent();
            _id = guid;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            roundedButton1_Click(sender, e);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            panelTag.Visible = false;
            panelProject.Visible = true;
            panel1.Visible = false;
            LoadProjects(false);
        }

        private void roundedButtonTag_Click(object sender, EventArgs e)
        {
            panelTag.Visible = true;
            panelProject.Visible = false;
            panel1.Visible = false;
            LoadTags();
        }

        private void roundedButtonUser_Click(object sender, EventArgs e)
        {
            panelTag.Visible = false;
            panelProject.Visible = false;
            panel1.Visible = true;
            LoadUsers();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string newTagName = textBoxTagNameAdd.Text.Trim();

            if (string.IsNullOrWhiteSpace(newTagName))
            {
                MessageBox.Show("Название тега не может быть пустым!");
                return;
            }

            using (var context = new SuflerDB())
            {
                // Проверка на существование тега
                if (context.tags.Any(t => t.tag_name == newTagName))
                {
                    MessageBox.Show("Этот тег уже существует!");
                    return;
                }

                // Добавление нового тега в базу данных
                var newTag = new tag
                {
                    tag_name = newTagName
                };

                context.tags.Add(newTag);
                context.SaveChanges();

                // Обновление списка тегов на форме
                LoadTags();
                textBoxTagNameAdd.Clear();
                MessageBox.Show("Тег успешно добавлен!");
            }
        }

        private void LoadTags()
        {
            using (var context = new SuflerDB())
            {
                var unusedTags = context.tags
                                        .Where(t => !t.projects.Any())
                                        .ToList();

                comboBoxTagDel.Items.Clear();
                comboBoxTagDel.Text = "";
                foreach (var tag in unusedTags)
                {
                    comboBoxTagDel.Items.Add(tag.tag_name);
                }
                comboBoxTagDel.SelectedIndex = unusedTags.Count == 0? -1 : 0;
            }
        }

        private void LoadProjects(bool published)
        {
            flowLayoutPanelProj.Controls.Clear(); // Очищаем текущие элементы
            using (var context = new SuflerDB())
            {
                var projects = context.projects
                    .Where(p => p._checked == published) // Исключаем проекты, принадлежащие текущему пользователю
                    .OrderByDescending(p => p.date_created)
                    .ToList();

                foreach (var proj in projects)
                {
                    var item = new CustomControl.AdminProjectItem(proj, _id);
                    item.Dock = DockStyle.Top;
                    flowLayoutPanelProj.Controls.Add(item);
                }
            }
        }

        private void LoadUsers(string searchQuery = "")
        {
            flowLayoutPanelUser.Controls.Clear();

            using (var context = new SuflerDB())
            {
                var usersQuery = context.users.Where(u => u.user_id != _id);

                // Фильтрация по имени или фамилии
                if (!string.IsNullOrWhiteSpace(searchQuery))
                {
                    usersQuery = usersQuery.Where(u => u.first_name.Contains(searchQuery) || u.last_name.Contains(searchQuery));
                }

                var users = usersQuery.OrderBy(u => u.first_name).ToList();

                foreach (var u in users)
                {
                    var userItem = new CustomControl.AdminUser(u, _id);
                    flowLayoutPanelUser.Controls.Add(userItem);
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            string selectedTag = comboBoxTagDel.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedTag))
            {
                MessageBox.Show("Пожалуйста, выберите тег для удаления.");
                return;
            }

            using (var context = new SuflerDB())
            {
                var tagToDelete = context.tags.FirstOrDefault(t => t.tag_name == selectedTag);

                if (tagToDelete != null)
                {
                    // Проверка, что тег не используется
                    if (tagToDelete.projects.Any())
                    {
                        MessageBox.Show("Этот тег используется в одном из проектов, его нельзя удалить.");
                        return;
                    }

                    // Удаление тега
                    context.tags.Remove(tagToDelete);
                    context.SaveChanges();

                    // Обновляем список тегов на форме
                    LoadTags();
                    MessageBox.Show("Тег успешно удален!");
                }
            }
        }

        private void roundedButtonDontPublished_Click(object sender, EventArgs e)
        {
            panelTag.Visible = false;
            panelProject.Visible = true;
            LoadProjects(false); // Неопубликованные
        }

        private void roundedButtonPublished_Click(object sender, EventArgs e)
        {
            panelTag.Visible = false;
            panelProject.Visible = true;
            LoadProjects(true); // Опубликованные
        }

        // Обработчик для поиска пользователей
        private void textBoxUserSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBoxFound.Text.Trim();
            LoadUsers(searchQuery);
        }

        // Обработчик для кнопки "Показать все"
        private void buttonAll_Click(object sender, EventArgs e)
        {
            textBoxFound.Clear();
            LoadUsers(); // Показать всех пользователей
        }

        private void buttonFound_Click(object sender, EventArgs e)
        {
            string searchQuery = textBoxFound.Text.Trim();
            LoadUsers(searchQuery);
        }
    }

}
