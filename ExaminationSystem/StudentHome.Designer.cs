namespace ExaminationSystem
{
    partial class StudentHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelStdName = new System.Windows.Forms.Label();
            this.labelStdID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelStdDepartment = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.btnStartExam = new System.Windows.Forms.Button();
            this.btnShowGades = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name:";
            // 
            // labelStdName
            // 
            this.labelStdName.AutoSize = true;
            this.labelStdName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStdName.Location = new System.Drawing.Point(179, 30);
            this.labelStdName.Name = "labelStdName";
            this.labelStdName.Size = new System.Drawing.Size(49, 21);
            this.labelStdName.TabIndex = 1;
            this.labelStdName.Text = "name";
            // 
            // labelStdID
            // 
            this.labelStdID.AutoSize = true;
            this.labelStdID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStdID.Location = new System.Drawing.Point(179, 70);
            this.labelStdID.Name = "labelStdID";
            this.labelStdID.Size = new System.Drawing.Size(25, 21);
            this.labelStdID.TabIndex = 2;
            this.labelStdID.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(33, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Department:";
            // 
            // labelStdDepartment
            // 
            this.labelStdDepartment.AutoSize = true;
            this.labelStdDepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStdDepartment.Location = new System.Drawing.Point(179, 106);
            this.labelStdDepartment.Name = "labelStdDepartment";
            this.labelStdDepartment.Size = new System.Drawing.Size(91, 21);
            this.labelStdDepartment.TabIndex = 5;
            this.labelStdDepartment.Text = "department";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(33, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Course:";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(179, 146);
            this.comboBoxCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(153, 29);
            this.comboBoxCourse.TabIndex = 7;
            // 
            // btnStartExam
            // 
            this.btnStartExam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartExam.Location = new System.Drawing.Point(325, 243);
            this.btnStartExam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartExam.Name = "btnStartExam";
            this.btnStartExam.Size = new System.Drawing.Size(160, 40);
            this.btnStartExam.TabIndex = 8;
            this.btnStartExam.Text = "Start Exam";
            this.btnStartExam.UseVisualStyleBackColor = true;
            this.btnStartExam.Click += new System.EventHandler(this.btnStartExam_Click);
            // 
            // btnShowGades
            // 
            this.btnShowGades.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowGades.Location = new System.Drawing.Point(325, 313);
            this.btnShowGades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowGades.Name = "btnShowGades";
            this.btnShowGades.Size = new System.Drawing.Size(160, 40);
            this.btnShowGades.TabIndex = 10;
            this.btnShowGades.Text = "Show All Grades";
            this.btnShowGades.UseVisualStyleBackColor = true;
            this.btnShowGades.Click += new System.EventHandler(this.btnShowGades_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.Location = new System.Drawing.Point(657, 391);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(94, 40);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnShowGades);
            this.Controls.Add(this.btnStartExam);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelStdDepartment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelStdID);
            this.Controls.Add(this.labelStdName);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(100, 50);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StudentHome";
            this.Load += new System.EventHandler(this.StudentHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label5;
        private Label label7;
        private Button btnStartExam;
        private Button btnShowGades;
        private Button btnLogOut;
        public Label labelStdName;
        public Label labelStdID;
        public Label labelStdDepartment;
        public ComboBox comboBoxCourse;
    }
}