using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.OleDb;
using System.Configuration;
using System.Data;

namespace Broker
{
    public partial class SearchForm : MaterialForm
    {
        private OleDbConnection dbConnection;
        public SearchForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            dbConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Broker"].ConnectionString);
            dbConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string operation = comboBox1.Text;

            string query = "Select [Код клиента], Дата, Наименование, Количество, Сумма FROM Акции WHERE Операции LIKE '%" + operation + "%'";
            OleDbDataAdapter command = new OleDbDataAdapter(query, dbConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            dbConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            dataGridView1.Columns.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StocksForm stocks = new StocksForm();
            stocks.Show();
            Hide();
        }        
    }
}
