using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.OleDb;
using System.Configuration;

namespace Broker
{
    public partial class EmployeeForm : MaterialForm
    {
        private OleDbConnection dbConnection;
        public EmployeeForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);            
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sberbankDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.sberbankDataSet.Сотрудники);

            dbConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Broker"].ConnectionString);
            dbConnection.Open();
        }

        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbConnection.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM Сотрудники WHERE [Код сотрудника] =" + kod;
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Сотрудник удален");
        }

        private void EditSurnamBtn_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox2.Text);
            string query = "UPDATE Сотрудники SET Фамилия = '" + tbSurname.Text + "' WHERE [Код сотрудника] =" + kod;
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Фамилия изменена");
        }

        private void EditPhoneBtn_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox2.Text);
            string query = "UPDATE Сотрудники SET Телефон = '" + tbPhone.Text + "' WHERE [Код сотрудника] =" + kod;
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Телефон изменен");
        }

        private void EditPosBtn_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox2.Text);
            string query = "UPDATE Сотрудники SET Должность = '" + cbPos.Text + "' WHERE [Код сотрудника] =" + kod;
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Должность изменена");
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            this.сотрудникиTableAdapter.Fill(this.sberbankDataSet.Сотрудники);
        }

        private void BtnAddEmp_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployee = new AddEmployeeForm();
            addEmployee.Show();
        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
            Hide();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            tbSurname.Text = "";
            tbPhone.Text = "";
            cbPos.Text = "";
        }
    }
}
