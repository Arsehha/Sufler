using Sufler.Models;
using Sufler.Properts;
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
    public partial class Review : System.Windows.Forms.UserControl
    {
        private review _rev;
        public Review()
        {
            InitializeComponent();
            Drawer.MakeControlRound(pictureBox1, 4);
        }

        public Review(review rev)
        {
            InitializeComponent();
            _rev = rev;
        }

        private void Review_Load(object sender, EventArgs e)
        {
            labelName.Text = GetUserName(_rev.reviewer); // Имя автора отзыва
            labelDate.Text = _rev.date_created.ToShortDateString();
            textBox1.Text = _rev.text; // Текст отзыва
            labelRate.Text = $"Оценка: {_rev.rate}";
        }

        private string GetUserName(Guid? reviewerId)
        {
            if (reviewerId == null) return "Аноним";

            using (var context = new SuflerDB())
            {
                var user = context.users.FirstOrDefault(u => u.user_id == reviewerId);
                return user != null ? $"{user.first_name} {user.last_name}" : "Неизвестный пользователь";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
