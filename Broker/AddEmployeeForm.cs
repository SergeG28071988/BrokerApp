using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.OleDb;
using System.Configuration;


namespace Broker
{
    public partial class AddEmployeeForm : MaterialForm
    {
        private OleDbConnection dbConnection;
        public AddEmployeeForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);            
        }

        private void AddEmployeeForm_Load(object sender, System.EventArgs e)
        {
            dbConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Broker"].ConnectionString);
            dbConnection.Open();
        }    

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(tbKod.Text);
            string Surname = tbSurname.Text;
            string Name = tbName.Text;
            string Phone = tbPhone.Text;
            string Position = cbPos.Text;

            string query = "INSERT INTO Сотрудники ([Код сотрудника], Фамилия, Имя, Телефон, Должность) VALUES (" + kod + ", '" + Surname + "', '" + Name + "', '" + Phone + "', '" + Position + "')";
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные добавлены");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            tbKod.Text = "";
            tbSurname.Text = "";
            tbName.Text = "";
            tbPhone.Text = "";
            cbPos.Text = "";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
