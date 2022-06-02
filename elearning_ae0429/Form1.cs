using System.Data.OleDb;

namespace elearning_ae0429
{
    public partial class frmLogIn : Form
    {
        public static String SetValueForUserName = "";
        public static String SetValueForid = "";
        public static String SetValueForaddgrade = "";
        public static String SetValueForjob = "";
        private List<Users> UserList = new List<Users>();
        public frmLogIn()
        {
            InitializeComponent();
            Users user1 = new Users("danya", "1234","ae0439","student");
            Users user2 = new Users("ahmad", "4321","ab9736","teacher");
            UserList.Add(user1);
            UserList.Add(user2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmSignUp frm = new frmSignUp();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string useName = txtUserName.Text;
            string password = txtPassword.Text;
            string teacher = "teacher";
            
                 foreach (Users user in UserList)
                 {
                    if (useName == user.UserName && password == user.Password)
                     {
                         SetValueForUserName = txtUserName.Text;
                         SetValueForid = user.UserId;
                         SetValueForjob = user.UserJob;
                       if (SetValueForjob ==teacher )
                        {
                            SetValueForaddgrade = "add grade";
                        }
                          frmHome frm = new frmHome();
                          frm.Show();
                          return;
                    }
                 }
                  MessageBox.Show("wrong username or password");
        }

        private void lbllogin_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}