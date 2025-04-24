using Sufler.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Sufler.Forms
{
    public partial class createProject : ParentForm
    {
        private Guid _user;
        private project _project;
        private SuflerDB context = new SuflerDB();

        public createProject()
        {
            InitializeComponent();
        }

        public createProject(Guid user)
        {
            InitializeComponent();
            _user = user;
        }

        public createProject(Guid user, project projectToEdit)
        {
            InitializeComponent();
            _user = user;
            _project = projectToEdit;
        }

        private void createProject_Load(object sender, EventArgs e)
        {
            LoadTags(); // Загружаем теги

            // Заполняем поля при редактировании проекта, если он был передан
            if (_project != null)
            {
                this.Text = "Редактирование проекта";
                project_nameTextBox.Text = _project.project_name;
                descriptionTextBox.Text = _project.description;
                date_endDateTimePicker.Value = _project.date_end > date_endDateTimePicker.MinDate ? _project.date_end : date_endDateTimePicker.MinDate;

                // Делаем проверку перед установкой значения
                if (_project.tags != null) // Убедитесь, что _project.tags не равно null
                {
                    Console.WriteLine($"Устанавливаем значение тега: {_project.tags}"); // Добавляем диагностику
                    tagsComboBox.SelectedValue = _project.tags;
                }
            }
            else
            {
                this.Text = "Создание проекта";
            }

            // Устанавливаем минимальную дату для выбора на следующий день
            date_endDateTimePicker.MinDate = DateTime.Now.AddDays(1); // Следующий день
        }

        private void LoadTags()
        {
            try
            {
                var tags = context.tags.ToList();

                if (tags.Count == 0)
                {
                    MessageBox.Show("Теги не найдены в базе данных!");
                    return;
                }

                tagsComboBox.DataSource = null;
                tagsComboBox.DisplayMember = "tag_name";
                tagsComboBox.ValueMember = "tag_id";
                tagsComboBox.DataSource = tags;

                // Безопасно устанавливаем выбранный элемент
                tagsComboBox.SelectedIndex = tags.Any() ? 0 : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке тегов: " + ex.Message);
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = project_nameTextBox.Text;
            var desc = descriptionTextBox.Text;
            var end = date_endDateTimePicker.Value;
            var price = (int)numericUpDown1.Value;
            var tagId = (int)tagsComboBox.SelectedValue;

            // Проверка обязательных полей
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Поле 'Название проекта' не может быть пустым!");
                return;
            }

            if (string.IsNullOrWhiteSpace(desc))
            {
                MessageBox.Show("Поле 'Описание' не может быть пустым!");
                return;
            }

            // Проверка даты окончания
            if (end < DateTime.Now)
            {
                MessageBox.Show("Дата окончания не может быть в прошлом!");
                return;
            }

            if (_project == null) // Если создаём новый проект
            {
                var newProject = new project
                {
                    project_id = Guid.NewGuid(),
                    project_name = name,
                    description = desc,
                    date_end = end,
                    tags = tagId,
                    price = price,
                    creator = _user,
                    date_created = DateTime.Now,
                    _checked = false,
                    compleated = false
                };

                context.projects.Add(newProject);
            }
            else // Если редактируем существующий проект
            {
                var proj = context.projects.FirstOrDefault(p => p.project_id == _project.project_id);
                if (proj != null)
                {
                    proj.project_name = name;
                    proj.description = desc;
                    proj.date_end = end;
                    proj.price = price;
                    proj.tags = tagId;
                    proj._checked = false;
                }
            }

            // Сохраняем изменения в базе данных
            context.SaveChanges();

            // Закрываем форму с успешным результатом
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
