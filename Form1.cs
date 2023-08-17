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

            Verification(user);

        }

        private void checkBoxRemember_CheckedChanged(object sender, EventArgs e)
        {
            /*Properties.Settings.Default.userName = textBoxName.Text;
            Properties.Settings.Default.passUser = textBoxPassword.Text;

            Properties.Settings.Default.Save();*/
        }

        private void Verification(User user) // pass the class totally
        {
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
                    mainForm form = new mainForm(user.Name, user.Password, connetionString);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No access, try again");
                    panelMove.Location = new Point(panelMove.Location.X, panelMove.Location.Y + 35);

                    /*int DistanceUnit = 1; // Method 1: create a label in the code   !GroupBox covers the label!
                    Label wrongUser = new Label();
                    this.Controls.Add(wrongUser); // Adding the lavel itselt

                    wrongUser.Top = DistanceUnit * 600;
                    wrongUser.Left = DistanceUnit * 600;
                    DistanceUnit = DistanceUnit + 1;

                    wrongUser.ForeColor = Color.Red;
                    wrongUser.AutoSize = true;
                    wrongUser.TextAlign = ContentAlignment.MiddleCenter;
                    wrongUser.Visible = true;
                    wrongUser.Text = "Wrong username or password, please try again :(";*/


                    wrongUser.Visible = true; // Method 2: hide the label and make it visible on click   !Intersects with the panelMove and also moves!
                    wrongUser.Location = new Point(wrongUser.Location.X, panelMove.Location.Y + 1);

                }
            }

            cnn.Close();
            command.Dispose();
            dataReader.Close();
        }


    }
}
