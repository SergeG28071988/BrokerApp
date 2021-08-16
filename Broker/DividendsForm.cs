using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.OleDb;
using System.Configuration;


namespace Broker
{
    public partial class DividendsForm : MaterialForm
    {
        private OleDbConnection dbConnection;
        public DividendsForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void DividendsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sberbankDataSet.Эмитенты". При необходимости она может быть перемещена или удалена.
            this.эмитентыTableAdapter.Fill(this.sberbankDataSet.Эмитенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sberbankDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.sberbankDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sberbankDataSet.Дивиденды". При необходимости она может быть перемещена или удалена.
            this.дивидендыTableAdapter.Fill(this.sberbankDataSet.Дивиденды);
            dbConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Broker"].ConnectionString);
            dbConnection.Open();
        }

        private void DividendsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClientForm client = new ClientForm();
            client.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            DateTime date = dateTimePicker1.Value;
            string client = comboBox1.Text;
            string name = comboBox2.Text;
            string count = textBox2.Text;
            string dividend = comboBox3.Text;
            string profit = textBox3.Text;

            string query = "INSERT INTO Дивиденды ([Код актива], Дата, Клиент, Наименование, Количество, Дивиденд, Сумма) " +
                "VALUES (" + kod + ", '" + date + "', '" + client + "', '" + name + "', '" + count + "', '" + dividend + "', '" + profit + "')";
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные добавлены");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.дивидендыTableAdapter.Fill(this.sberbankDataSet.Дивиденды);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dividend; 
            double count;

            dividend = Convert.ToDouble(comboBox3.Text);
            count = Convert.ToDouble(textBox2.Text);

            switch (comboBox4.Text)
            {
                case "*":

                    textBox3.Text = Convert.ToString(dividend * count);
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DividendsClientsForm dividends = new DividendsClientsForm();
            dividends.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }        
    }
}
