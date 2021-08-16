using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.OleDb;
using System.Configuration;

namespace Broker
{    
    public partial class StocksForm : MaterialForm
    {
        private OleDbConnection dbConnection;
        public StocksForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void StocksForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sberbankDataSet.Акции". При необходимости она может быть перемещена или удалена.
            this.акцииTableAdapter.Fill(this.sberbankDataSet.Акции);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sberbankDataSet.Акции". При необходимости она может быть перемещена или удалена.
            this.акцииTableAdapter.Fill(this.sberbankDataSet.Акции);

            dbConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Broker"].ConnectionString);
            dbConnection.Open();
        }

        private void StocksForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbConnection.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddStocksForm addStocks = new AddStocksForm();
            addStocks.Show();            
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            this.акцииTableAdapter.Fill(this.sberbankDataSet.Акции);
        }       

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm();
            search.Show();
            Hide();
        }

        private void SearchClientBtn_Click(object sender, EventArgs e)
        {
            SearchForm1 searchForm = new SearchForm1();
            searchForm.Show();
            Hide();
        }

        private void returnClientsBtn_Click(object sender, EventArgs e)
        {
            ClientForm client = new ClientForm();
            client.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "UPDATE Акции  SET Дата = '" + dateTimePicker1.Value  + "' WHERE [Код акции] =" + kod;
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Дата изменена");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "UPDATE Акции  SET Наименование = '" + textBox2.Text + "' WHERE [Код акции] =" + kod;
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Наименование изменено");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "UPDATE Акции  SET Описаниее = '" + textBox3.Text + "' WHERE [Код акции] =" + kod;
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Описание изменено");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "UPDATE Акции  SET Цена = '" + textBox4.Text + "' WHERE [Код акции] =" + kod;
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Цена изменена");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "UPDATE Акции  SET Количество = '" + textBox5.Text + "' WHERE [Код акции] =" + kod;
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Количество изменено");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double price;
            double count;

            price = Convert.ToDouble(textBox4.Text);
            count = Convert.ToDouble(textBox5.Text);

            switch (comboBox1.Text)
            {
                case "*":

                    textBox6.Text = Convert.ToString(price * count);
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "UPDATE Акции  SET Сумма = '" + textBox6.Text + "' WHERE [Код акции] =" + kod;
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Сумма изменена");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "UPDATE Акции  SET Операции = '" + comboBox2.Text + "' WHERE [Код акции] =" + kod;
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Вид операции изменен");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox7.Text);
            string query = "DELETE FROM Акции WHERE [Код акции] =" + kod;
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Актив удален");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";        

            comboBox1.Text = "";
            comboBox2.Text = "";
        }       
    }
}
