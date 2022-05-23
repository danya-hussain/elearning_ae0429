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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            frm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmSubjects frm = new frmSubjects();
            frm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmGrades frm = new frmGrades();
            frm.Show();
        }

        private void frmHome_Load_2(object sender, EventArgs e)
        {
            lblUserNameHome.Text = frmLogIn.SetValueForUserName;
            lblName.Text = lblUserNameHome.Text;
            lblId.Text = frmLogIn.SetValueForid;
            lblAddGrades.Text= frmLogIn.SetValueForaddgrade;
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogIn frm = new frmLogIn();
            frm.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblAddGrades_Click(object sender, EventArgs e)
        {
            frmAddGrade frm = new frmAddGrade();
            frm.Show();
        }
    }
}
