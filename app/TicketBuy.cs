using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_sales
{
    public partial class TicketBuy : Form
    {
        private List<TicketData> db;
        public TicketBuy(List<TicketData> init_db)
        {
            InitializeComponent();
            db = init_db;
        }
        private void isReturn_CheckedChanged(object sender, EventArgs e)
        {
            bool isReturnShow = isReturn.Checked;
            arrive_date.Visible = isReturnShow;
            label6.Visible = isReturnShow;
        }

        private void search_Click(object sender, EventArgs e)
        {
            bool isReturnFlight = isReturn.Checked;
            // Валидация входных параметров
            if (depart.Text.Length == 0 
                || arrive.Text.Length == 0 
                || depart_date.Text.Length == 0 
                || (isReturnFlight && arrive_date.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!", "Уведомление");
                return;
            }

            int count_matched_flights = isReturnFlight ? 2 : 1,
                counter = 0;
            bool showed = false;
            string storagePath = @"C:\Users\flush\source\repos\Ticket sales\Database.txt",
                newLine1 = "", newLine2 = "";

            foreach (TicketData flight in db) {
                if (counter == 0 
                    && string.Equals(depart.Text, flight.depart)
                    && string.Equals(arrive.Text, flight.arrive)
                    && string.Equals(depart_date.Text, flight.date_depart)) {
                    newLine1 = depart.Text + "-" + arrive.Text + " " + depart_date.Text + '\n';
                    if (++counter == count_matched_flights)
                    {
                        MessageBox.Show("Билет куплен!", "Уведомление");
                        showed = true;
                        using (StreamWriter writer = new StreamWriter(storagePath))
                        {
                            // Добавление новой строки в конец файла
                            writer.WriteLine(newLine1);
                        }
                        break;
                    }
                } else if (counter == 1 && depart.Text == flight.arrive && arrive.Text == flight.depart && arrive_date.Text == flight.date_depart)
                {
                    MessageBox.Show("Билет куплен!", "Уведомление");
                    showed = true;
                    newLine2 = arrive.Text + "-" + depart.Text + " " + arrive_date.Text + '\n';
                    using (StreamWriter writer = new StreamWriter(storagePath))
                    {
                        // Добавление новой строки в конец файла
                        writer.WriteLine(newLine1 + "-----------------------\n" + newLine2);
                    }
                    break;
                }
            }
            if (!showed)
            {
                MessageBox.Show("Предложение не найдено", "Уведомление");
            }
        }
    }
}

