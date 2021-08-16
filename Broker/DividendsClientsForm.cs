using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.OleDb;
using System.Configuration;
using System.Data;

namespace Broker
{
    public partial class DividendsClientsForm : MaterialForm
    {
        private OleDbConnection dbConnection;
        public DividendsClientsForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.BlueGrey700,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void DividendsClientsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sberbankDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.sberbankDataSet.Клиенты);
            dbConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Broker"].ConnectionString);
            dbConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string client = comboBox1.Text;

            string query = "Select Дата, Наименование, Сумма FROM Дивиденды WHERE Клиент LIKE '%" + client + "%'" ;

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
            DividendsForm dividends = new DividendsForm();
            dividends.Show();
            Hide();
        }
    }
}
