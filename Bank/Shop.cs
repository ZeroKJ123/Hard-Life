using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 dlg = new Form1();
            dlg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Account.money >= 1200)
            {
                Account.money -= 1200;
                MessageBox.Show("Вы купили пивандепалу и сразу банхнули её");
            }
            else
            {
                double x = 1200 - Account.money;
                MessageBox.Show($"У вас не хватает {x} бабок");
            }
        }
    }
}
