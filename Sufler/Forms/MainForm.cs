using Sufler.CustomControl;
using Sufler.Models;
using Sufler.Properties;
using Sufler.Properts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sufler.Forms
{
    public partial class MainForm : ParentForm
    {
        private Panel profileDropdownPanel;
        private bool isDropdownVisible = false;
        private user currentUser;

        public MainForm()
        {
            InitializeComponent();
            Drawer.MakeControlRound(pictureBoxAvatar, 4);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (currentUser == null)
            {
                ShowAuthForm();
            }
        }

        private void ShowAuthForm()
        {
            using (AuthForm authForm = new AuthForm())
            {
                // Показываем форму авторизации как модальное окно
                var result = authForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Получаем объект user из Tag
                    this.currentUser = authForm.Tag as user;

                    if (this.currentUser != null)
                    {
                        InitUI();
                        this.Show(); // Показываем главную форму
                        ShowWorks();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при получении данных пользователя");
                        Application.Exit();
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
        }



        private void InitUI()
        {
            // Получаем имя пользователя из переменной currentUser
            string userName = $"{currentUser.first_name} {currentUser.last_name}";
            labelName.Text = userName;

            RedrawProfileDropdownPanel();
        }

        private void RedrawProfileDropdownPanel()
        {
            // Удаляем старую панель дропдауна (если она уже существует)
            if (profileDropdownPanel != null && profileDropdownPanel.Parent != null)
            {
                profileDropdownPanel.Parent.Controls.Remove(profileDropdownPanel);
            }

            // Пересоздаем панель с дропдауном
            profileDropdownPanel = new Panel
            {
                Size = new Size(150, 150),
                Location = new Point(this.Width - 150, 0),
                BackColor = Color.LightGray,
                Visible = false
            };

            // Добавляем элементы в меню
            AddDropdownItems();

            // Добавляем панель с дропдауном в правую часть формы
            splitContainer.Panel2.Controls.Add(profileDropdownPanel);


        }

        private void AddDropdownItems()
        {
            // Очищаем панель перед добавлением новых элементов
            profileDropdownPanel.Controls.Clear();

            var items = new[] { "Выйти", "Выйти из аккаунта", "Профиль" };

            // Получаем роль пользователя из переменной currentUser
            string userRole = currentUser.role;

            // Добавляем кнопки в меню
            foreach (var text in items)
            {
                var btn = new Button
                {
                    Text = text,
                    Dock = DockStyle.Top,
                    Height = 30,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.LightGray,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 0, 0, 0)
                };

                // Обработчик нажатия
                btn.Click += (sender, e) =>
                {
                    // Действие, зависящее от текста кнопки
                    switch (text)
                    {
                        case "Выйти":
                            Application.Exit();
                            break;
                        case "Выйти из аккаунта":
                            Logout();
                            break;
                        case "Профиль":
                            OpenProfile();
                            break;
                        case "Админ панель":
                            OpenAdminPanel();
                            break;
                    }

                    // Закрыть выпадающее меню после нажатия на кнопку
                    profileDropdownPanel.Visible = false;
                    isDropdownVisible = false;
                };

                profileDropdownPanel.Controls.Add(btn);
            }

            // Добавляем кнопку "Админ панель", если роль "admin" или "moderator"
            if (userRole == "admin" || userRole == "moderator")
            {
                var adminPanelBtn = new Button
                {
                    Text = "Админ панель",
                    Dock = DockStyle.Top,
                    Height = 30,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.LightGray,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 0, 0, 0)
                };

                // Обработчик нажатия для кнопки админ панели
                adminPanelBtn.Click += (sender, e) =>
                {
                    OpenAdminPanel();
                    profileDropdownPanel.Visible = false;
                    isDropdownVisible = false;
                };

                profileDropdownPanel.Controls.Add(adminPanelBtn);
            }

            // Обновляем размер панели в зависимости от количества кнопок
            profileDropdownPanel.Height = profileDropdownPanel.Controls.Count * 30; // Высота кнопок
        }

        private void pictureBoxAvatar_Click(object sender, EventArgs e)
        {
            isDropdownVisible = !isDropdownVisible;
            profileDropdownPanel.Visible = isDropdownVisible;
            if (isDropdownVisible)
                profileDropdownPanel.BringToFront();
        }

        private void OpenAdminPanel()
        {
            AdminForm adminForm = new AdminForm(currentUser.user_id);
            adminForm.ShowDialog();
        }

        private void OpenProfile()
        {
            ProfileForm profileForm = new ProfileForm(currentUser.user_id, currentUser.user_id);
            var result = profileForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Logout();
            }
        }

        private void ShowMyProjectsPanel()
        {
            splitContainer.Panel2.Controls.Clear();

            var myProjectsPanel = new MyprojectsPanel(currentUser.user_id);
            myProjectsPanel.Dock = DockStyle.Fill;

            splitContainer.Panel2.Controls.Add(myProjectsPanel);
            RedrawProfileDropdownPanel();
        }
        private void ShowWorks()
        {
            splitContainer.Panel2.Controls.Clear();

            var work = new FindJob(currentUser);
            work.Dock = DockStyle.Fill;

            splitContainer.Panel2.Controls.Add(work);
            RedrawProfileDropdownPanel();
        }


        private void ShowMyWorkPanel()
        {
            splitContainer.Panel2.Controls.Clear();

            var myJob= new MyJobPanel(currentUser.user_id);
            myJob.Dock = DockStyle.Fill;

            splitContainer.Panel2.Controls.Add(myJob);
            RedrawProfileDropdownPanel();
        }

        private void Logout()
        {
            // Очистить данные о текущем пользователе
            currentUser = null;

            // Очистить выпадающее меню
            profileDropdownPanel?.Dispose(); // Удаляем старое меню, если оно существует

            // Закрыть текущую форму
            this.Hide(); // Скрыть форму MainForm
            this.Controls.Clear();

            InitializeComponent();
            Drawer.MakeControlRound(pictureBoxAvatar, 4);

            // Переход к форме авторизации
            ShowAuthForm();
        }



        private void roundedButton3_Click(object sender, EventArgs e)
        {
            ShowMyProjectsPanel();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            ShowMyWorkPanel();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            ShowWorks();
        }
    }
}
