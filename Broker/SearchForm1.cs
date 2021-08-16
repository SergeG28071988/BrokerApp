using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.OleDb;
using System.Configuration;
using System.Data;

namespace Broker
{
    public partial class SearchForm1 : MaterialForm
    {
        private OleDbConnection dbConnection;
        public SearchForm1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void SearchForm1_Load(object sender, EventArgs e)
        {
            dbConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Broker"].ConnectionString);
            dbConnection.Open();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);

            string query = "Select Дата, Наименование, Количество, Сумма, Операции  FROM Акции WHERE [Код клиента] LIKE '%" + kod + "%'";
            OleDbDataAdapter command = new OleDbDataAdapter(query, dbConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView2.DataSource = dt;
            dbConnection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dataGridView2.Columns.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StocksForm stocks = new StocksForm();
            stocks.Show();
            Hide();
        }
    }
}
