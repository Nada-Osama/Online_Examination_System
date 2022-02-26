namespace ExaminationSystem
{
    partial class frmShowAllGrades
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
            this.labelStudentName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.labelDept = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridViewStdGrades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStdGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name:";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentName.Location = new System.Drawing.Point(142, 30);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(49, 21);
            this.labelStudentName.TabIndex = 1;
            this.labelStudentName.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student ID:";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentID.Location = new System.Drawing.Point(130, 74);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(25, 21);
            this.labelStudentID.TabIndex = 3;
            this.labelStudentID.Text = "ID";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(477, 44);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(96, 21);
            this.label.TabIndex = 4;
            this.label.Text = "Department:";
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDept.Location = new System.Drawing.Point(575, 44);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(91, 21);
            this.labelDept.TabIndex = 5;
            this.labelDept.Text = "department";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(653, 391);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 44);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridViewStdGrades
            // 
            this.dataGridViewStdGrades.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewStdGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStdGrades.Location = new System.Drawing.Point(178, 132);
            this.dataGridViewStdGrades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewStdGrades.Name = "dataGridViewStdGrades";
            this.dataGridViewStdGrades.RowHeadersWidth = 51;
            this.dataGridViewStdGrades.RowTemplate.Height = 29;
            this.dataGridViewStdGrades.Size = new System.Drawing.Size(347, 239);
            this.dataGridViewStdGrades.TabIndex = 7;
            // 
            // frmShowAllGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridViewStdGrades);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelDept);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelStudentName);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(100, 50);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmShowAllGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmShowAllGrades";
            this.Load += new System.EventHandler(this.frmShowAllGrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStdGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label labelStudentName;
        private Label label3;
        private Label labelStudentID;
        private Label label;
        private Label labelDept;
        private Button btnBack;
        private DataGridView dataGridViewStdGrades;
    }
}