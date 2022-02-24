using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class InstructorHome : Form
    {
        public InstructorHome()
        {
            InitializeComponent();
        }

        frmGenerateExam frmGenerateExam=new frmGenerateExam();
        private void btnGenerateExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGenerateExam.ShowDialog();
        }

        private void btnCorrectExam_Click(object sender, EventArgs e)
        {

        }
        Login login=new Login();
        private void InstructorHome_Load(object sender, EventArgs e)
        {
            labelInsId.Text = login.id.ToString();
            labelInsName.Text = login.name;
            this.Invalidate();

        }
    }
}
