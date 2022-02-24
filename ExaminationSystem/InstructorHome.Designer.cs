namespace ExaminationSystem
{
    partial class InstructorHome
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
            this.labelInsName = new System.Windows.Forms.Label();
            this.labelInsId = new System.Windows.Forms.Label();
            this.btnGenerateExam = new System.Windows.Forms.Button();
            this.btnCorrectExam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInsName
            // 
            this.labelInsName.AutoSize = true;
            this.labelInsName.Location = new System.Drawing.Point(283, 100);
            this.labelInsName.Name = "labelInsName";
            this.labelInsName.Size = new System.Drawing.Size(49, 20);
            this.labelInsName.TabIndex = 0;
            this.labelInsName.Text = "Name";
            // 
            // labelInsId
            // 
            this.labelInsId.AutoSize = true;
            this.labelInsId.Location = new System.Drawing.Point(470, 100);
            this.labelInsId.Name = "labelInsId";
            this.labelInsId.Size = new System.Drawing.Size(24, 20);
            this.labelInsId.TabIndex = 1;
            this.labelInsId.Text = "ID";
            // 
            // btnGenerateExam
            // 
            this.btnGenerateExam.Location = new System.Drawing.Point(357, 205);
            this.btnGenerateExam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerateExam.Name = "btnGenerateExam";
            this.btnGenerateExam.Size = new System.Drawing.Size(136, 31);
            this.btnGenerateExam.TabIndex = 2;
            this.btnGenerateExam.Text = "Generate Exam";
            this.btnGenerateExam.UseVisualStyleBackColor = true;
            this.btnGenerateExam.Click += new System.EventHandler(this.btnGenerateExam_Click);
            // 
            // btnCorrectExam
            // 
            this.btnCorrectExam.Location = new System.Drawing.Point(357, 303);
            this.btnCorrectExam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCorrectExam.Name = "btnCorrectExam";
            this.btnCorrectExam.Size = new System.Drawing.Size(136, 31);
            this.btnCorrectExam.TabIndex = 3;
            this.btnCorrectExam.Text = "Correct Exam";
            this.btnCorrectExam.UseVisualStyleBackColor = true;
            this.btnCorrectExam.Click += new System.EventHandler(this.btnCorrectExam_Click);
            // 
            // InstructorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnCorrectExam);
            this.Controls.Add(this.btnGenerateExam);
            this.Controls.Add(this.labelInsId);
            this.Controls.Add(this.labelInsName);
            this.Location = new System.Drawing.Point(50, 50);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InstructorHome";
            this.Text = "InstructorHome";
            this.Load += new System.EventHandler(this.InstructorHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnGenerateExam;
        private Button btnCorrectExam;
        public Label labelInsName;
        public Label labelInsId;
    }
}