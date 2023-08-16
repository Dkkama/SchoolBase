using System.Data.SqlClient;
using System.Xml.Linq;

namespace SchoolBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string password = textBoxPassword.Text;
            bool check = checkBoxRemember.Checked;

            User user = new User(name, password);

            Verification();
            
        }

        private void checkBoxRemember_CheckedChanged(object sender, EventArgs e)
        {
            /*Properties.Settings.Default.userName = textBoxName.Text;
            Properties.Settings.Default.passUser = textBoxPassword.Text;

            Properties.Settings.Default.Save();*/
        }

        private void Verification()
        {
            User user = new User(Name, Password); // ERROR

            string connetionString = @"Data Source=LAPTOP-KAMILYA\SQLEXPRESS;Initial Catalog=SchoolBase;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            string sqlVerify = "Select username, password from LogIn";
            SqlCommand command = new SqlCommand(sqlVerify, cnn);

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                if (user.Name == dataReader.GetString(0) && user.Password == dataReader.GetString(1))
                {
                    MessageBox.Show("Access");
                    mainForm form = new mainForm(user.Name, user.Password, connetionString);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No access, try again");
                }
            }

            cnn.Close();
            command.Dispose();
            dataReader.Close();
        }
    }
}
