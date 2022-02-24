namespace ExaminationSystem
{
    partial class frmGenerateExam
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
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.numericUpDownTF = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMCQ = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerateExam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMCQ)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(407, 71);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(151, 28);
            this.comboBoxCourse.TabIndex = 0;
            // 
            // numericUpDownTF
            // 
            this.numericUpDownTF.Location = new System.Drawing.Point(408, 140);
            this.numericUpDownTF.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTF.Name = "numericUpDownTF";
            this.numericUpDownTF.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownTF.TabIndex = 1;
            // 
            // numericUpDownMCQ
            // 
            this.numericUpDownMCQ.Location = new System.Drawing.Point(408, 213);
            this.numericUpDownMCQ.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMCQ.Name = "numericUpDownMCQ";
            this.numericUpDownMCQ.ReadOnly = true;
            this.numericUpDownMCQ.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownMCQ.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "No. of T/F questions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "No. of choices questions";
            // 
            // btnGenerateExam
            // 
            this.btnGenerateExam.Location = new System.Drawing.Point(308, 304);
            this.btnGenerateExam.Name = "btnGenerateExam";
            this.btnGenerateExam.Size = new System.Drawing.Size(133, 29);
            this.btnGenerateExam.TabIndex = 6;
            this.btnGenerateExam.Text = "Generate Exam";
            this.btnGenerateExam.UseVisualStyleBackColor = true;
            this.btnGenerateExam.Click += new System.EventHandler(this.btnGenerateExam_Click);
            // 
            // frmGenerateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerateExam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownMCQ);
            this.Controls.Add(this.numericUpDownTF);
            this.Controls.Add(this.comboBoxCourse);
            this.Name = "frmGenerateExam";
            this.Text = "frmGenerateExam";
            this.Load += new System.EventHandler(this.frmGenerateExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMCQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxCourse;
        private NumericUpDown numericUpDownTF;
        private NumericUpDown numericUpDownMCQ;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGenerateExam;
    }
}