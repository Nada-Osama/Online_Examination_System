//using ExaminationSystem.Context;
using ExaminationSystem.Context2;
using ExaminationSystem.Entities2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class TestForm : Form
    {
        Online_Examination_SystemContext context = new();
 
        
        
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
      


            List<Student> list;
            string sql = "EXEC selectAllStudent";
            list = context.Students.FromSqlRaw<Student>(sql).ToList();
            dataGridView1.DataSource= list;

            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
