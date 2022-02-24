using ExaminationSystem.Context2;

namespace ExaminationSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }


        Online_Examination_SystemContext context=new();
        public string name;
        public int id;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            InstructorHome Instructorhome = new InstructorHome();
            StudentHome StudentHome = new StudentHome();
             name = txtUserNameFrm1.Text;
             id = int.Parse(txtIDFrm1.Text);
            if (radioInstructor.Checked)
            {
            
                
            var instructiorName=(from  I in context.Instructors
                             select I.InsName).ToList();
            var instructorID= (from I in context.Instructors
                               select I.InsId).ToList();
            for(int i=0;i<instructiorName.Count;i++)
            {
                if (instructiorName[i] == name && instructorID[i] == id)
                {
                      this.Hide();
                      Instructorhome.ShowDialog();
                     // Instructorhome.labelInsId.Text =id.ToString();
                      //Instructorhome.labelInsName.Text = name;
                       // this.Invalidate();
                        break;

                }
                    else
                    {
                        lblFailed.Visible = true;

                        break;
                    }
            }
                

            }
            if(radioStudent.Checked)
            {
                var studentName = (from I in context.Students
                                       select I.StFname).ToList();
                var studentID = (from I in context.Students
                                    select I.StId).ToList();
                for (int i = 0; i < studentName.Count; i++)
                {
                    if (studentName[i] == name && studentID[i] == id)
                    {
                        this.Hide();
                        StudentHome.ShowDialog();
                        break;
                    }
                    else
                    {
                        lblFailed.Visible = true;
                        break;
                    }
                }
            }
              

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFailed.Visible = false;
        }
    }
}