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

            mainForm form = new mainForm(name, password, check);
            form.ShowDialog();

            User user = new User(name, password);
        }

        private void checkBoxRemember_CheckedChanged(object sender, EventArgs e)
        {
            /*Properties.Settings.Default.userName = textBoxName.Text;
            Properties.Settings.Default.passUser = textBoxPassword.Text;

            Properties.Settings.Default.Save();*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
