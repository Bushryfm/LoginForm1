namespace Login1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                lblResult.Text = "Please Enter UserName and password";
            }
            else

            if (txtUserName.Text == "Bushry" && txtPassword.Text == "123456")
            {
                lblResult.Text = "Successfully Logged in";
            }
            else
            {
                lblResult.Text = "Invalid UserName or Password";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
    }
}
