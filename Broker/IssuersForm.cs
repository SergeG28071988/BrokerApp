using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.OleDb;
using System.Configuration;

namespace Broker
{
    public partial class IssuersForm : MaterialForm
    {
        private OleDbConnection dbConnection;
        public IssuersForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void IssuersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sberbankDataSet.Эмитенты". При необходимости она может быть перемещена или удалена.
            this.эмитентыTableAdapter.Fill(this.sberbankDataSet.Эмитенты);
            dbConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Broker"].ConnectionString);
            dbConnection.Open();
        }

        private void IssuersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            string dividends = textBox3.Text;

            string query = "INSERT INTO Эмитенты ([Код эмитента], Наименование, Дивиденды) VALUES (" + kod + ", '" + name + "', '" + dividends + "')";
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные добавлены");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.эмитентыTableAdapter.Fill(this.sberbankDataSet.Эмитенты);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            Hide();
        }
    }
}
