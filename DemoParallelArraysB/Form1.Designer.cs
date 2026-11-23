namespace DemoParallelArraysB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lblGrade = new Label();
            txtStudent = new TextBox();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 53);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Student:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 103);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Grade:";
            // 
            // lblGrade
            // 
            lblGrade.BorderStyle = BorderStyle.FixedSingle;
            lblGrade.Location = new Point(228, 102);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(125, 30);
            lblGrade.TabIndex = 2;
            // 
            // txtStudent
            // 
            txtStudent.Location = new Point(228, 50);
            txtStudent.Name = "txtStudent";
            txtStudent.Size = new Size(125, 27);
            txtStudent.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(114, 160);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(239, 75);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search Grade";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 285);
            Controls.Add(btnSearch);
            Controls.Add(txtStudent);
            Controls.Add(lblGrade);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Brightspace";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblGrade;
        private TextBox txtStudent;
        private Button btnSearch;
    }
}
