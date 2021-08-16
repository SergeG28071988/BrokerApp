using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.OleDb;
using System.Configuration;

namespace Broker
{
    public partial class AddStocksForm : MaterialForm
    {     
        private OleDbConnection dbConnection;
        public AddStocksForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void AddStocksForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sberbankDataSet.Эмитенты". При необходимости она может быть перемещена или удалена.
            this.эмитентыTableAdapter.Fill(this.sberbankDataSet.Эмитенты);
            dbConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Broker"].ConnectionString);
            dbConnection.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            int kod_2 = Convert.ToInt32(textBox2.Text);
            DateTime date = dateTimePicker1.Value; 
            string name = comboBox3.Text;
            string description = textBox5.Text;
            string price = textBox6.Text;
            string quantity = textBox7.Text;
            string profit = textBox8.Text;
            string operation = comboBox1.Text;

            string query = "INSERT INTO Акции ([Код акции], [Код клиента], Дата, Наименование, Описание, Цена, Количество, Сумма, Операции) VALUES(" + kod + ", " + kod_2 + ", '" + date + "', '" + name + "', '" + description + "', '" + price + "', '" + quantity + "', '" + profit + "', '" + operation + "')";
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные добавлены");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";               
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price;
            double quantity;

            price = Convert.ToDouble(textBox6.Text);
            quantity = Convert.ToDouble(textBox7.Text);

            switch (comboBox2.Text)
            {
                case "*":

                    textBox8.Text = Convert.ToString(price * quantity);
                    break;
            }
        }
    }
}
