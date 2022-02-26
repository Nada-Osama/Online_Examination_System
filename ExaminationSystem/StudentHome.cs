using ExaminationSystem.Context2;
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
    public partial class StudentHome : Form
    {
        static public string course;

        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Login"];
        Online_Examination_SystemContext context = new Online_Examination_SystemContext();
        frmGenerateExam frmGenerateExam = new frmGenerateExam();
        frmStartExam frmStartExam = new frmStartExam();
        frmShowAllGrades frm = new frmShowAllGrades();

        public StudentHome()
        {
            InitializeComponent();
        }

        private void StudentHome_Load(object sender, EventArgs e)
        {
            labelStdID.Text = ((Login)f).txtIDFrm1.Text;
            labelStdName.Text = ((Login)f).txtUserNameFrm1.Text;
            var departments = (from S in context.Students
                               where S.StFname == ((Login)f).txtUserNameFrm1.Text && S.StId == int.Parse(((Login)f).txtIDFrm1.Text)
                               select S.Dept.DeptName);
            labelStdDepartment.Text = departments.FirstOrDefault();
            comboBoxCourse.DataSource = (from C in context.Courses
                                         select C.CrsName).ToList();
            comboBoxCourse.DisplayMember = "Crs_Name";
            comboBoxCourse.SelectedValueChanged += (sender, e) => course = comboBoxCourse.SelectedItem.ToString();
        }

        private void btnStartExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStartExam.Location = this.Location;
            frmStartExam.ShowDialog();
        }

        private void btnShowGades_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Location = this.Location;
            frm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            this.Close();
            ((Login)f).txtIDFrm1.Text = String.Empty;
            ((Login)f).txtUserNameFrm1.Text = String.Empty;
            ((Login)f).radioStudent.Checked = false;
            ((Login)f).lblFailed.Visible = false;
            ((Login)f).ShowDialog();
        }
    }
}
