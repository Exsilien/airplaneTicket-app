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
    public partial class Main : Form
    {
        private Auth auth_page = new Auth();
        bool isAuth = false;
        private List<TicketData> Ticket_DB = new List<TicketData>();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void auth_Click(object sender, EventArgs e)
        {
            try
            {
                auth_page.Show();
            }
            catch
            {
                auth_page = new Auth();
                auth_page.Show();
                isAuth = auth_page.isAuth();
            }
        }

        private void add_ticket_Click(object sender, EventArgs e)
        {
            if (auth_page.isAuth() || isAuth)
            {
                Wrapper<List<TicketData>> wrapper = new Wrapper<List<TicketData>>(Ticket_DB);
                BaseAdd baseAdd = new BaseAdd(wrapper);
                baseAdd.Show();
                isAuth = true;
            }
            else
            {
                isAuth = false;
                MessageBox.Show("Вы не вошли", "Уведомление");
            }
        }

        private void buy_ticket_Click(object sender, EventArgs e)
        {
            TicketBuy form = new TicketBuy(Ticket_DB);
            form.Show();
        }

    }

    public class TicketData
    {
        public string depart, arrive, date_depart;
        public TicketData(string init_depart, string init_arrive, string init_date_depart)
        {
            depart = init_depart;
            arrive = init_arrive;
            date_depart = init_date_depart;
        }
    }
    public class Wrapper<T>
    {
        public T Value { get; set; }
        public Wrapper(T initialValue)
        {
            Value = initialValue;
        }
    }

}

