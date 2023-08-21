using System;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace SchoolBase
{
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
        }
        private bool wrongUserFlag = false;

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
        public void wrongUserFunction()
        {
            if (!wrongUserFlag)
            {
                // MessageBox.Show("No access, try again");
                panelMove.Location = new Point(panelMove.Location.X, panelMove.Location.Y + 35);

                int DistanceUnit = 1;
                Label wrongUser = new Label();
                this.Controls.Add(wrongUser); // Adding the label itselt

                wrongUser.Top = DistanceUnit * 605;
                wrongUser.Left = DistanceUnit * 1000;
                DistanceUnit = DistanceUnit + 1;

                wrongUser.ForeColor = Color.Red;
                wrongUser.AutoSize = true;
                wrongUser.TextAlign = ContentAlignment.MiddleCenter;
                wrongUser.Visible = true;
                wrongUser.Text = "Wrong username or password, please try again :(";
                wrongUser.BringToFront(); // prevents from GroupBox covering the label}

                wrongUserFlag = true;
            }
        }
        private void Verification(User user)
        {
            string connetionString = @"Data Source=LAPTOP-KAMILYA\SQLEXPRESS;Initial Catalog=SchoolBase;Integrated Security=True";

            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                cnn.Open();

                string sqlLogIn = "SELECT username, password FROM LogIn";
                SqlCommand command = new SqlCommand(sqlLogIn, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                bool userFound = false;

                while (dataReader.Read())
                {
                    for (int i = 0; i < dataReader.FieldCount; i += 2) // dataReader.FieldCount
                                                                        // Iterate every even index
                    {
                        if (!dataReader.IsDBNull(i))
                        {
                            string username = dataReader.GetString(i);
                            if (user.Name == username && user.Password == dataReader.GetString(i + 1))
                            {
                                mainForm form = new mainForm(user.Name, user.Password, connetionString);
                                form.ShowDialog();
                                userFound = true;
                                break;
                            }
                        }
                    }
                    if (userFound)
                    {
                        break;
                    }
                }
                dataReader.Close();

                if (!userFound)
                {
                    using (SqlConnection cnnStudents = new SqlConnection(connetionString))
                    {
                        cnnStudents.Open();

                        string sqlLogInStudents = "SELECT username, password FROM LogInStudents";
                        SqlCommand commandStudents = new SqlCommand(sqlLogInStudents, cnnStudents);

                        SqlDataReader dataReaderStudents = commandStudents.ExecuteReader();

                        while (dataReaderStudents.Read())
                        {
                            for (int i = 0; i < dataReaderStudents.FieldCount; i += 2)
                            {
                                if (!dataReaderStudents.IsDBNull(i))
                                {
                                    string username = dataReaderStudents.GetString(i);
                                    if (user.Name == username && user.Password == dataReaderStudents.GetString(i + 1)) 
                                    {
                                        MessageBox.Show("Student");
                                        userFound = true;
                                        break;
                                    }
                                }
                            }
                            if (userFound)
                            {
                                break;
                            }
                        }
                        dataReaderStudents.Close();
                    }
                }
                if (!userFound)
                {
                    wrongUserFunction();
                }
            }
        }





    }
}
