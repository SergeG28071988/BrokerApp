using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.OleDb;
using System.Configuration;

namespace Broker
{
    public partial class AddClientForm : MaterialForm
    {
        private OleDbConnection dbConnection;
        public AddClientForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {
            dbConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Broker"].ConnectionString);
            dbConnection.Open();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            int kod_2 = Convert.ToInt32(textBox2.Text);
            string Surname = textBox3.Text;
            string Name = textBox4.Text;
            string Phone = textBox5.Text;

            string query = "INSERT INTO Клиенты ([Код клиента], [Код сотрудника], Фамилия, Имя, Телефон) VALUES (" + kod + ", " + kod_2 +", '" + Surname + "', '" + Name + "', '" + Phone + "')";
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные добавлены");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
