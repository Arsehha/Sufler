using Sufler.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Sufler.Forms
{
    public partial class ResponseForm : Form
    {
        private project _project;
        private Guid _user;

        public ResponseForm()
        {
            InitializeComponent();
        }

        public ResponseForm(project project, Guid user)
        {
            InitializeComponent();
            _project = project;
            _user = user;
        }

        private void ResponseForm_Load(object sender, EventArgs e)
        {
            // Загрузка данных из таблицы откликов (необязательно при отправке нового отклика)
            this.responseTableAdapter.Fill(this.sufler_MironovDataSet.response);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Введите сообщение перед отправкой.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new SuflerDB())
            {
                bool alreadyResponded = db.responses.Any(r =>
                    r.id_user == _user && r.id_project == _project.project_id);

                if (alreadyResponded)
                {
                    MessageBox.Show("Вы уже отправили отклик на этот проект.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var newResponse = new response
                {
                    id_user = _user,
                    id_project = _project.project_id,
                    message = message,
                };

                db.responses.Add(newResponse);
                db.SaveChanges();
            }

            MessageBox.Show("Отклик успешно отправлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void responseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.responseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sufler_MironovDataSet);
        }
    }
}
