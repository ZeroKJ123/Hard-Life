using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Bank
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            Account account = new Account();

            InitializeComponent();
            double x = Account.money;
            label2.Text = x + " руб";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Work dlg = new Work();
            dlg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shop dlg = new Shop();
            dlg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://qiwi.com/n/18ZERO18") { UseShellExecute = true });
        }
    }
}