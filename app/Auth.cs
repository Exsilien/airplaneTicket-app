using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_sales
{
    public partial class Auth : Form
    {
        private bool isLogin = false;
        public Auth()
        {
            InitializeComponent();
        }
        public bool isAuth() { return isLogin; }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("Вы успешно авторизовались!", "Уведомление");
                isLogin = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Уведомление");
                isLogin = false;
            }
        }

    }
}
