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
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownModels = new System.Windows.Forms.NumericUpDown();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMCQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModels)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(421, 59);
            this.comboBoxCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(176, 29);
            this.comboBoxCourse.TabIndex = 0;
            // 
            // numericUpDownTF
            // 
            this.numericUpDownTF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownTF.Location = new System.Drawing.Point(421, 111);
            this.numericUpDownTF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownTF.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTF.Name = "numericUpDownTF";
            this.numericUpDownTF.Size = new System.Drawing.Size(176, 29);
            this.numericUpDownTF.TabIndex = 1;
            // 
            // numericUpDownMCQ
            // 
            this.numericUpDownMCQ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownMCQ.Location = new System.Drawing.Point(421, 164);
            this.numericUpDownMCQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownMCQ.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMCQ.Name = "numericUpDownMCQ";
            this.numericUpDownMCQ.ReadOnly = true;
            this.numericUpDownMCQ.Size = new System.Drawing.Size(176, 29);
            this.numericUpDownMCQ.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(141, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(141, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "No. of T/F questions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(141, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "No. of choices questions";
            // 
            // btnGenerateExam
            // 
            this.btnGenerateExam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateExam.Location = new System.Drawing.Point(295, 309);
            this.btnGenerateExam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateExam.Name = "btnGenerateExam";
            this.btnGenerateExam.Size = new System.Drawing.Size(160, 40);
            this.btnGenerateExam.TabIndex = 6;
            this.btnGenerateExam.Text = "Generate Exam";
            this.btnGenerateExam.UseVisualStyleBackColor = true;
            this.btnGenerateExam.Click += new System.EventHandler(this.btnGenerateExam_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(141, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "No. of Models";
            // 
            // numericUpDownModels
            // 
            this.numericUpDownModels.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownModels.Location = new System.Drawing.Point(421, 213);
            this.numericUpDownModels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownModels.Name = "numericUpDownModels";
            this.numericUpDownModels.Size = new System.Drawing.Size(176, 29);
            this.numericUpDownModels.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(671, 409);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 41);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmGenerateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.numericUpDownModels);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGenerateExam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownMCQ);
            this.Controls.Add(this.numericUpDownTF);
            this.Controls.Add(this.comboBoxCourse);
            this.Location = new System.Drawing.Point(100, 50);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGenerateExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmGenerateExam";
            this.Load += new System.EventHandler(this.frmGenerateExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMCQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModels)).EndInit();
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
        private Label label5;
        private NumericUpDown numericUpDownModels;
        private Button btnBack;
    }
}