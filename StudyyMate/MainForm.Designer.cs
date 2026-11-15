namespace StudyyMate
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            panel3 = new Panel();
            btnExit = new Button();
            btnProgressTracker = new Button();
            btnTimetable = new Button();
            btnFlashcards = new Button();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(96, 125, 139);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnProgressTracker);
            panel1.Controls.Add(btnTimetable);
            panel1.Controls.Add(btnFlashcards);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 508);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 183, 77);
            panel3.Location = new Point(3, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 56);
            panel3.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(33, 369);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(226, 68);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnProgressTracker
            // 
            btnProgressTracker.FlatAppearance.BorderSize = 0;
            btnProgressTracker.FlatStyle = FlatStyle.Flat;
            btnProgressTracker.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProgressTracker.ForeColor = Color.White;
            btnProgressTracker.Location = new Point(33, 275);
            btnProgressTracker.Name = "btnProgressTracker";
            btnProgressTracker.Size = new Size(226, 68);
            btnProgressTracker.TabIndex = 2;
            btnProgressTracker.Text = "Progress Tracker";
            btnProgressTracker.TextAlign = ContentAlignment.MiddleLeft;
            btnProgressTracker.UseVisualStyleBackColor = true;
            btnProgressTracker.Click += btnProgressTracker_Click;
            // 
            // btnTimetable
            // 
            btnTimetable.FlatAppearance.BorderSize = 0;
            btnTimetable.FlatStyle = FlatStyle.Flat;
            btnTimetable.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimetable.ForeColor = Color.White;
            btnTimetable.Location = new Point(33, 169);
            btnTimetable.Name = "btnTimetable";
            btnTimetable.Size = new Size(226, 68);
            btnTimetable.TabIndex = 2;
            btnTimetable.Text = "Study Timetable";
            btnTimetable.TextAlign = ContentAlignment.MiddleLeft;
            btnTimetable.UseVisualStyleBackColor = true;
            btnTimetable.Click += btnTimetable_Click;
            // 
            // btnFlashcards
            // 
            btnFlashcards.FlatAppearance.BorderSize = 0;
            btnFlashcards.FlatStyle = FlatStyle.Flat;
            btnFlashcards.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFlashcards.ForeColor = Color.White;
            btnFlashcards.Location = new Point(33, 69);
            btnFlashcards.Name = "btnFlashcards";
            btnFlashcards.Size = new Size(226, 68);
            btnFlashcards.TabIndex = 2;
            btnFlashcards.Text = "Flashcards";
            btnFlashcards.TextAlign = ContentAlignment.MiddleLeft;
            btnFlashcards.UseVisualStyleBackColor = true;
            btnFlashcards.Click += btnFlashcards_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 183, 77);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(262, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(562, 12);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(38, 50, 56);
            label1.Location = new Point(348, 100);
            label1.Name = "label1";
            label1.Size = new Size(342, 34);
            label1.TabIndex = 2;
            label1.Text = "Welcome To StudyMate.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(427, 371);
            label2.Name = "label2";
            label2.Size = new Size(299, 28);
            label2.TabIndex = 3;
            label2.Text = "your personal learning assistant";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(387, 152);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 239, 241);
            ClientSize = new Size(824, 508);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnFlashcards;
        private Button btnProgressTracker;
        private Button btnTimetable;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Button btnExit;
        private PictureBox pictureBox1;
    }
}
