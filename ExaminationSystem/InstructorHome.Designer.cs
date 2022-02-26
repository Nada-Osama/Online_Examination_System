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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExamResult = new System.Windows.Forms.Button();
            this.btngetInstructorCourses = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panelCourses = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelPanelInsID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPanelInsName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.panelCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInsName
            // 
            this.labelInsName.AutoSize = true;
            this.labelInsName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInsName.Location = new System.Drawing.Point(278, 75);
            this.labelInsName.Name = "labelInsName";
            this.labelInsName.Size = new System.Drawing.Size(52, 21);
            this.labelInsName.TabIndex = 0;
            this.labelInsName.Text = "Name";
            // 
            // labelInsId
            // 
            this.labelInsId.AutoSize = true;
            this.labelInsId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInsId.Location = new System.Drawing.Point(576, 75);
            this.labelInsId.Name = "labelInsId";
            this.labelInsId.Size = new System.Drawing.Size(25, 21);
            this.labelInsId.TabIndex = 1;
            this.labelInsId.Text = "ID";
            // 
            // btnGenerateExam
            // 
            this.btnGenerateExam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateExam.Location = new System.Drawing.Point(312, 148);
            this.btnGenerateExam.Name = "btnGenerateExam";
            this.btnGenerateExam.Size = new System.Drawing.Size(150, 40);
            this.btnGenerateExam.TabIndex = 2;
            this.btnGenerateExam.Text = "Generate Exam";
            this.btnGenerateExam.UseVisualStyleBackColor = true;
            this.btnGenerateExam.Click += new System.EventHandler(this.btnGenerateExam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(142, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Instructor Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(467, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Instructor ID :";
            // 
            // btnExamResult
            // 
            this.btnExamResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExamResult.Location = new System.Drawing.Point(312, 225);
            this.btnExamResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExamResult.Name = "btnExamResult";
            this.btnExamResult.Size = new System.Drawing.Size(150, 40);
            this.btnExamResult.TabIndex = 10;
            this.btnExamResult.Text = "Exam Result";
            this.btnExamResult.UseVisualStyleBackColor = true;
            this.btnExamResult.Click += new System.EventHandler(this.btnExamResult_Click);
            // 
            // btngetInstructorCourses
            // 
            this.btngetInstructorCourses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btngetInstructorCourses.Location = new System.Drawing.Point(312, 307);
            this.btngetInstructorCourses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btngetInstructorCourses.Name = "btngetInstructorCourses";
            this.btngetInstructorCourses.Size = new System.Drawing.Size(150, 40);
            this.btngetInstructorCourses.TabIndex = 11;
            this.btngetInstructorCourses.Text = "My Courses";
            this.btngetInstructorCourses.UseVisualStyleBackColor = true;
            this.btngetInstructorCourses.Click += new System.EventHandler(this.btngetInstructorCourses_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogOut.Location = new System.Drawing.Point(663, 386);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(82, 41);
            this.buttonLogOut.TabIndex = 12;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // panelCourses
            // 
            this.panelCourses.Controls.Add(this.btnBack);
            this.panelCourses.Controls.Add(this.labelPanelInsID);
            this.panelCourses.Controls.Add(this.label5);
            this.panelCourses.Controls.Add(this.labelPanelInsName);
            this.panelCourses.Controls.Add(this.label3);
            this.panelCourses.Controls.Add(this.dataGridViewCourses);
            this.panelCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCourses.Location = new System.Drawing.Point(0, 0);
            this.panelCourses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCourses.Name = "panelCourses";
            this.panelCourses.Size = new System.Drawing.Size(784, 461);
            this.panelCourses.TabIndex = 19;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(664, 396);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 36);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // labelPanelInsID
            // 
            this.labelPanelInsID.AutoSize = true;
            this.labelPanelInsID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPanelInsID.Location = new System.Drawing.Point(593, 112);
            this.labelPanelInsID.MinimumSize = new System.Drawing.Size(50, 20);
            this.labelPanelInsID.Name = "labelPanelInsID";
            this.labelPanelInsID.Size = new System.Drawing.Size(50, 21);
            this.labelPanelInsID.TabIndex = 4;
            this.labelPanelInsID.Text = "id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(478, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Instructor ID:";
            // 
            // labelPanelInsName
            // 
            this.labelPanelInsName.AutoSize = true;
            this.labelPanelInsName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPanelInsName.Location = new System.Drawing.Point(259, 112);
            this.labelPanelInsName.MinimumSize = new System.Drawing.Size(100, 20);
            this.labelPanelInsName.Name = "labelPanelInsName";
            this.labelPanelInsName.Size = new System.Drawing.Size(100, 21);
            this.labelPanelInsName.TabIndex = 2;
            this.labelPanelInsName.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(127, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Instructor Name:";
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(248, 182);
            this.dataGridViewCourses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowHeadersWidth = 51;
            this.dataGridViewCourses.RowTemplate.Height = 29;
            this.dataGridViewCourses.Size = new System.Drawing.Size(243, 165);
            this.dataGridViewCourses.TabIndex = 0;
            // 
            // InstructorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panelCourses);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.btngetInstructorCourses);
            this.Controls.Add(this.btnExamResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerateExam);
            this.Controls.Add(this.labelInsId);
            this.Controls.Add(this.labelInsName);
            this.Location = new System.Drawing.Point(100, 50);
            this.Name = "InstructorHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "InstructorHome";
            this.Load += new System.EventHandler(this.InstructorHome_Load);
            this.panelCourses.ResumeLayout(false);
            this.panelCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnGenerateExam;
        public Label labelInsName;
        public Label labelInsId;
        private Label label1;
        private Label label2;
        private Button btnExamResult;
        private Button btngetInstructorCourses;
        private Button buttonLogOut;
        private Panel panelCourses;
        private Button btnBack;
        private Label labelPanelInsID;
        private Label label5;
        private Label labelPanelInsName;
        private Label label3;
        private DataGridView dataGridViewCourses;
    }
}