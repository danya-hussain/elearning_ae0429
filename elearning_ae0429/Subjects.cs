using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elearning_ae0429
{
    public partial class frmSubjects : Form
    {
        public frmSubjects()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogIn frm = new frmLogIn();
            frm.Show();
        }

        private void frmSubjects_Load(object sender, EventArgs e)
        {
            lblUserNameHome.Text = frmLogIn.SetValueForUserName;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            frm.Show();
        }

        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubjects frm = new frmSubjects();
            frm.Show();
        }

        private void gradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrades frm = new frmGrades();
            frm.Show();
        }

       

        private void lblsub1_Click(object sender, EventArgs e)
        {

        }
    }
}
