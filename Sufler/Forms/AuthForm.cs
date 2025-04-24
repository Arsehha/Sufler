using Sufler.Models;
using Sufler.Properties;
using Sufler.Properts;
using Sufler.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sufler.Forms
{ 

    /// <summary>
    /// Форма авторизации/регистрации
    /// </summary>
    public partial class AuthForm : ParentForm
    {
        public string Number { get; set; }
        public string Password { get; set; }

        private int hide = 0;

        private Panel panelRegister;
        private int registerStep = 0;

        private TextBox nameBox, surnameBox;
        private DateTimePicker birthDatePicker;
        private MaskedTextBox phoneBox;
        private TextBox passwordBox, repeatPasswordBox;
        private RoundedButton registerNextButton, registerPrevButton, registerButton, toLoginButton;

        public AuthForm()
        {
            InitializeComponent();
            Drawer.RoundForm(this, 30);
            InitPanels();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private void InitPanels()
        {
            panelLogin.Dock = DockStyle.Fill;

            panelRegister = new Panel() { Dock = DockStyle.Fill, BackColor = Color.Transparent, Visible = false };
            InitRegisterControls();

            this.splitContainer.Panel2.Controls.Add(panelRegister);
        }

        private void InitRegisterControls()
        {
            // Шаг 0: Имя, Фамилия, Дата рождения
            var nameLabel = new Label() { Name = "Имя", Text = "Имя", Location = new Point(65, 10), AutoSize = true };
            nameBox = new TextBox() { Location = new Point(65, 30), Size = new Size(200, 30) };

            var surnameLabel = new Label() { Name = "Фамилия", Text = "Фамилия", Location = new Point(65, 60), AutoSize = true };
            surnameBox = new TextBox() { Location = new Point(65, 80), Size = new Size(200, 30) };

            var birthLabel = new Label() { Name = "Дата рождения", Text = "Дата рождения", Location = new Point(65, 110), AutoSize = true };
            birthDatePicker = new DateTimePicker()
            {
                Location = new Point(65, 130),
                Format = DateTimePickerFormat.Short,
                MaxDate = DateTime.Now.AddYears(-14)
            };

            // Шаг 1: Телефон
            var phoneLabel = new Label() { Name = "Телефон", Text = "Телефон", Location = new Point(65, 110), AutoSize = true };
            phoneBox = new MaskedTextBox("+7 (000) 000-00-00") { Location = new Point(65, 130), Size = new Size(200, 30) };

            // Шаг 2: Пароль и подтверждение
            var passLabel = new Label() { Name = "Пароль", Text = "Пароль", Location = new Point(65, 60), AutoSize = true };
            passwordBox = new TextBox() { Location = new Point(65, 80), Size = new Size(200, 30), UseSystemPasswordChar = true };

            var repeatPassLabel = new Label() { Name = "Повторите пароль", Text = "Повторите пароль", Location = new Point(65, 110), AutoSize = true };
            repeatPasswordBox = new TextBox() { Location = new Point(65, 130), Size = new Size(200, 30), UseSystemPasswordChar = true };

            // Кнопки
            registerPrevButton = new RoundedButton() { Text = "Назад", Location = new Point(40, 160), Size = new Size(120, 25), Enabled = false, BackgroundColor = Color.Transparent, BorderRadius = 13, BorderSize = 2, BorderColor = Color.Black };
            registerNextButton = new RoundedButton() { Text = "Далее", Location = new Point(170, 160), Size = new Size(120, 25), BackgroundColor = Color.Transparent, BorderRadius = 13, BorderSize = 2, BorderColor = Color.Black };
            registerButton = new RoundedButton() { Text = "Зарегистрироваться", Location = new Point(40, 190), Size = new Size(250, 30), Enabled = false, BackgroundColor = Color.Transparent, BorderRadius = 15, BorderSize = 2, BorderColor = Color.Black };

            toLoginButton = new RoundedButton()
            {
                Text = "Назад к авторизации",
                Location = new Point(40, 230),
                Size = new Size(250, 35),
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                BackgroundColor = Color.Transparent,
                BorderRadius = 18,
            };

            toLoginButton.FlatStyle = FlatStyle.Flat;
            toLoginButton.FlatAppearance.BorderSize = 0;
            toLoginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 229, 255);
            toLoginButton.Click += (s, e) => ShowAuthPanel();

            registerNextButton.Click += (s, e) => NextStep();
            registerPrevButton.Click += (s, e) => PrevStep();
            registerButton.Click += OnRegisterButtonClick;

            repeatPasswordBox.TextChanged += (s, e) =>
            {
                registerButton.Enabled = passwordBox.Text == repeatPasswordBox.Text && passwordBox.Text.Length >= 6;
            };

            // Добавляем всё в контролы панели регистрации
            panelRegister.Controls.AddRange(new Control[] {
                nameLabel, nameBox,
                surnameLabel, surnameBox,
                birthLabel, birthDatePicker,
                phoneLabel, phoneBox,
                passLabel, passwordBox,
                repeatPassLabel, repeatPasswordBox,
                registerPrevButton, registerNextButton, registerButton,
                toLoginButton
            });
        }

        private void pictureBoxCLose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            OnLoginButtonClick(sender, e);
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            ShowRegisterPanel();
        }

        private void pictureBoxLoginPass_Click(object sender, EventArgs e)
        {
            if (hide == 0)
            {
                textBoxLoginPass.PasswordChar = '\0'; // показываем пароль
                pictureBoxLoginPass.Image = Resources.view; // иконка "глаз открыт"
                hide = 1;
            }
            else
            {
                textBoxLoginPass.PasswordChar = '●'; // скрываем пароль
                pictureBoxLoginPass.Image = Resources.hide; // иконка "глаз закрыт"
                hide = 0;
            }
        }

        private void ClearFormFields()
        {
            textBoxLoginPhone.Clear();
            textBoxLoginPass.Clear();
            nameBox.Clear();
            surnameBox.Clear();
            phoneBox.Clear();
            passwordBox.Clear();
            repeatPasswordBox.Clear();

            birthDatePicker.Value = DateTime.Now.AddYears(-18);
        }

        private void ShowAuthPanel()
        {
            ClearFormFields();
            panelRegister.Visible = false;
            panelLogin.Visible = true;
        }

        private void ShowRegisterPanel()
        {
            ClearFormFields();
            registerStep = 0;
            panelLogin.Visible = false;
            panelRegister.Visible = true;
            UpdateRegisterStep();
        }

        private void UpdateRegisterStep()
        {
            // Шаг 0
            nameBox.Visible = surnameBox.Visible = birthDatePicker.Visible =
            panelRegister.Controls["Имя"].Visible = panelRegister.Controls["Фамилия"].Visible = panelRegister.Controls["Дата рождения"].Visible =
                (registerStep == 0);

            // Шаг 1
            phoneBox.Visible = panelRegister.Controls["Телефон"].Visible = (registerStep == 1);

            // Шаг 2
            passwordBox.Visible = repeatPasswordBox.Visible =
            panelRegister.Controls["Пароль"].Visible = panelRegister.Controls["Повторите пароль"].Visible =
                (registerStep == 2);

            // Управление кнопок
            registerPrevButton.Enabled = registerStep > 0;
            registerNextButton.Enabled = registerStep < 2;
            registerButton.Enabled = registerStep == 2;
        }

        private void NextStep()
        {
            if (registerStep == 0)
            {
                // Шаг 0: Проверка на заполненность имени, фамилии и даты рождения
                if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(surnameBox.Text) || birthDatePicker.Value == null)
                {
                    MessageBox.Show("Пожалуйста, заполните все поля (Имя, Фамилия, Дата рождения).");
                    return;
                }

                if (nameBox.Text.Length < 4 || nameBox.Text.Length > 15)
                {
                    MessageBox.Show("Имя должно быть длинной от 4  до 15 символов.");
                    return;
                }

                if (surnameBox.Text.Length < 4 || surnameBox.Text.Length > 15)
                {
                    MessageBox.Show("Фамилия должна быть длинной от 4  до 15 символов.");
                    return;
                }

                int age = DateTime.Now.Year - birthDatePicker.Value.Year;
                if (birthDatePicker.Value > DateTime.Now.AddYears(-age)) age--;
                if (age < 14)
                {
                    MessageBox.Show("Вам должно быть не менее 14 лет.");
                    return;
                }
            }

            if (registerStep == 1)
            {
                // Шаг 1: Проверка на заполненность телефона
                if (string.IsNullOrEmpty(phoneBox.Text) || !phoneBox.MaskCompleted)
                {
                    MessageBox.Show("Пожалуйста, введите номер телефона.");
                    return;
                }

                // Проверка на существование номера телефона в базе данных
                using (var context = new SuflerDB())
                {
                    var existingUser = context.users.FirstOrDefault(u => u.phone == phoneBox.Text);
                    if (existingUser != null)
                    {
                        MessageBox.Show("Пользователь с таким номером телефона уже существует.");
                        return;
                    }
                }
            }

            if (registerStep == 2)
            {
                // Шаг 2: Проверка на заполненность пароля и подтверждения пароля
                if (string.IsNullOrEmpty(passwordBox.Text) || string.IsNullOrEmpty(repeatPasswordBox.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните оба поля пароля.");
                    return;
                }

                if (passwordBox.Text != repeatPasswordBox.Text)
                {
                    MessageBox.Show("Пароли не совпадают.");
                    return;
                }
            }

            // Если все проверки пройдены, переходим на следующий шаг
            if (registerStep < 2)
            {
                registerStep++;
                UpdateRegisterStep();
            }
        }

        private void PrevStep()
        {
            if (registerStep > 0)
            {
                registerStep--;
                UpdateRegisterStep();
            }
        }

        private void OnLoginButtonClick(object sender, EventArgs e)
        {
            // Проверка на пустые поля
            if (string.IsNullOrEmpty(textBoxLoginPhone.Text) || string.IsNullOrEmpty(textBoxLoginPass.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            // Проверка на существование пользователя с таким номером телефона
            using (var context = new SuflerDB())
            {
                var existingUser = context.users.FirstOrDefault(u => u.phone == textBoxLoginPhone.Text);
                if (existingUser == null)
                {
                    MessageBox.Show("Пользователь с таким номером телефона не найден.");
                    return;
                }

                // Проверка на совпадение пароля
                if (existingUser.password != HashPassword(textBoxLoginPass.Text))
                {
                    MessageBox.Show("Неверный пароль.");
                    return;
                }

                // Возвращаем объект пользователя вместо UUID
                this.DialogResult = DialogResult.OK;
                this.Tag = existingUser;
                this.Close(); // Закрываем форму
            }
        }



        private void OnRegisterButtonClick(object sender, EventArgs e)
        {
            // Проверка на пустые поля
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(surnameBox.Text) ||
                string.IsNullOrEmpty(phoneBox.Text) || string.IsNullOrEmpty(passwordBox.Text) || string.IsNullOrEmpty(repeatPasswordBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            if (passwordBox.Text.Length < 8 || passwordBox.Text.Length > 20)
            {
                MessageBox.Show("Пароль должен содержать от 8 до 20 символов.");
                return;
            }

            // Проверка совпадения паролей
            if (passwordBox.Text != repeatPasswordBox.Text)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }

            // Проверка на существование номера телефона в базе данных
            if (IsPhoneNumberExist(phoneBox.Text))
            {
                MessageBox.Show("Пользователь с таким номером телефона уже существует.");
                return;
            }

            // Создание нового пользователя
            using (var context = new SuflerDB())
            {
                try
                {
                    var newUser = new user
                    {
                        user_id = Guid.NewGuid(),
                        first_name = nameBox.Text,
                        last_name = surnameBox.Text,
                        date_birth = birthDatePicker.Value,
                        phone = phoneBox.Text,
                        password = HashPassword(passwordBox.Text),
                        bio = string.Empty,
                        role = "user"
                    };

                    context.users.Add(newUser);
                    context.SaveChanges(); // Пытаемся сохранить данные в базе

                    // Закрытие формы и возврат UUID
                    this.DialogResult = DialogResult.OK;
                    this.Tag = newUser;  // Сохраняем объект пользователя в свойство Tag
                    this.Close(); // Закрытие формы после успешной регистрации
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationError in ex.EntityValidationErrors)
                    {
                        foreach (var error in validationError.ValidationErrors)
                        {
                            MessageBox.Show($"Property: {error.PropertyName}, Error: {error.ErrorMessage}");
                        }
                    }
                }
            }
        }


        // Метод для проверки, существует ли пользователь с таким номером телефона
        private bool IsPhoneNumberExist(string phoneNumber)
        {
            using (var context = new SuflerDB())
            {
                var existingUser = context.users.FirstOrDefault(u => u.phone == phoneNumber);
                return existingUser != null;  // Если пользователь найден, возвращаем true
            }
        }

        //Хеширование пароля
        public string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
