namespace StudyyMate.Forms
{
    partial class TimetableForm
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
            txtSubjectName = new TextBox();
            nudHours = new NumericUpDown();
            btnAddSubject = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lvSubjects = new ListView();
            btnGenerate = new Button();
            nudPriority = new NumericUpDown();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)nudHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPriority).BeginInit();
            SuspendLayout();
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(117, 14);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(355, 31);
            txtSubjectName.TabIndex = 0;
            // 
            // nudHours
            // 
            nudHours.Location = new Point(264, 51);
            nudHours.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudHours.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudHours.Name = "nudHours";
            nudHours.Size = new Size(193, 31);
            nudHours.TabIndex = 1;
            nudHours.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddSubject
            // 
            btnAddSubject.BackColor = Color.FromArgb(96, 125, 139);
            btnAddSubject.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddSubject.ForeColor = Color.White;
            btnAddSubject.Location = new Point(155, 144);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(182, 34);
            btnAddSubject.TabIndex = 3;
            btnAddSubject.Text = "Add Subject";
            btnAddSubject.UseVisualStyleBackColor = false;
            btnAddSubject.Click += btnAddSubject_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 5;
            label1.Text = "Subject:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 6;
            label2.Text = "Hours per Week:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 7;
            label3.Text = "Priority";
            // 
            // lvSubjects
            // 
            lvSubjects.FullRowSelect = true;
            lvSubjects.GridLines = true;
            lvSubjects.Location = new Point(78, 251);
            lvSubjects.Name = "lvSubjects";
            lvSubjects.Size = new Size(336, 229);
            lvSubjects.TabIndex = 8;
            lvSubjects.UseCompatibleStateImageBehavior = false;
            lvSubjects.View = View.Details;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(96, 125, 139);
            btnGenerate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(145, 184);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(203, 34);
            btnGenerate.TabIndex = 9;
            btnGenerate.Text = "Generate Timetable";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // nudPriority
            // 
            nudPriority.Location = new Point(264, 88);
            nudPriority.Name = "nudPriority";
            nudPriority.Size = new Size(193, 31);
            nudPriority.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 183, 77);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 484);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 8);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 183, 77);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 8);
            panel2.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 183, 77);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(8, 476);
            panel3.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 183, 77);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(482, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(8, 476);
            panel4.TabIndex = 14;
            // 
            // TimetableForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 492);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(nudPriority);
            Controls.Add(btnGenerate);
            Controls.Add(lvSubjects);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddSubject);
            Controls.Add(nudHours);
            Controls.Add(txtSubjectName);
            Name = "TimetableForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TimetableForm";
            WindowState = FormWindowState.Maximized;
            Load += TimetableForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPriority).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSubjectName;
        private NumericUpDown nudHours;
        private Button btnAddSubject;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView lvSubjects;
        private Button btnGenerate;
        private NumericUpDown nudPriority;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}