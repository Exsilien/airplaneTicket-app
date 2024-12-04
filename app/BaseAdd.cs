using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Ticket_sales
{
    public partial class BaseAdd : Form
    {
        private Wrapper<List<TicketData>> DB;
        public BaseAdd(Wrapper<List<TicketData>> wrapper)
        {
            InitializeComponent();
            DB = wrapper;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date_format = "dd.MM.yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;
            if (!DateTime.TryParseExact(textBox3.Text, date_format, provider, DateTimeStyles.None, out DateTime parsedDate))
            {
                MessageBox.Show("Введена неправильная дата!", "Ошибка");
                return;
            }
           TicketData flight = new(textBox1.Text, textBox2.Text, textBox3.Text);
            DB.Value.Add(flight);
            MessageBox.Show("Рейс добавлен");
        }
    }
}
