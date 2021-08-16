using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace Broker
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, 
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void EmployeeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            EmployeeForm employee = new EmployeeForm();
            employee.Show();
            Hide();
        }

        private void ClientsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
            Hide();
        }

        private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }       

        private void StocksToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            StocksForm stocks = new StocksForm();
            stocks.Show();
            Hide();
        }

        private void IssuersToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            IssuersForm issuers = new IssuersForm();
            issuers.Show();
            Hide();
        }

        private void DividendsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            DividendsForm dividends = new DividendsForm();
            dividends.Show();
            Hide();
        }       

        private void AboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Справка
            MessageBox.Show("Автор программы Брокерская фирма: Сергей Галкин., \nДата релиза: 16.08.2021 г., \nEmail: galckinserega@gmail.com", "Внимание!!");
        }
    }
}
