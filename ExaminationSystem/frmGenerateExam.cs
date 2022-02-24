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
    public partial class frmGenerateExam : Form
    {
        public frmGenerateExam()
        {
            InitializeComponent();
        }

        private void btnGenerateExam_Click(object sender, EventArgs e)
        {

        }
        Online_Examination_SystemContext context = new();

        private void frmGenerateExam_Load(object sender, EventArgs e)
        {
            comboBoxCourse.DataSource=(from C in context.Courses
                                       select C.CrsName).ToList();

            comboBoxCourse.DisplayMember = "Crs_Name";
         
            numericUpDownTF.ValueChanged+=(sender, e)=>numericUpDownMCQ.Value=10 - numericUpDownTF.Value;
            numericUpDownMCQ.ValueChanged += (sender, e) => numericUpDownTF.Value = 10 - numericUpDownMCQ.Value;

            this.Refresh();
        }
    }
}
