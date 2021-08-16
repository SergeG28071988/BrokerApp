using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.OleDb;
using System.Configuration;

namespace Broker
{
    public partial class ClientForm : MaterialForm
    {
        private OleDbConnection dbConnection;
        public ClientForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sberbankDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.sberbankDataSet.Клиенты);

            dbConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Broker"].ConnectionString);
            dbConnection.Open();

        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbConnection.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM Клиенты WHERE [Код клиента] =" + kod;
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Клиент удален");
        }

        private void editSurnameBtn_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox2.Text);
            string query = "UPDATE Клиенты SET Фамилия = '" + tbSurname.Text + "' WHERE [Код клиента] =" + kod;
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Фамилия изменена");
        }

        private void editPhoneBtn_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox2.Text);
            string query = "UPDATE Клиенты SET Телефон = '" + tbPhone.Text + "' WHERE [Код клиента] =" + kod;
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Телефон изменен");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            this.клиентыTableAdapter.Fill(this.sberbankDataSet.Клиенты);
        }

        private void returnEmployeeBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm employee = new EmployeeForm();
            employee.Show();
            Hide();
        }

        private void returnMenuBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            tbSurname.Text = "";
            tbPhone.Text = "";
        }

        private void addClientBtn_Click(object sender, EventArgs e)
        {
            AddClientForm clientForm = new AddClientForm();
            clientForm.Show();
        }

        private void StocksBtn_Click(object sender, EventArgs e)
        {
            StocksForm stocks = new StocksForm();
            stocks.Show();
            Hide();
        }

        private void DividendsBtn_Click(object sender, EventArgs e)
        {
            DividendsForm dividends = new DividendsForm();
            dividends.Show();
            Hide();
        }
    }
}
