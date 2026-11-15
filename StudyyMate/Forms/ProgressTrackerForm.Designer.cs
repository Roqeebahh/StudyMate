namespace StudyyMate.Forms
{
    partial class ProgressTrackerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressTrackerForm));
            lvProgress = new ListView();
            btnMarkCompleted = new Button();
            lblStatus = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lvProgress
            // 
            lvProgress.FullRowSelect = true;
            lvProgress.GridLines = true;
            lvProgress.Location = new Point(0, 47);
            lvProgress.Name = "lvProgress";
            lvProgress.Size = new Size(800, 223);
            lvProgress.TabIndex = 0;
            lvProgress.UseCompatibleStateImageBehavior = false;
            lvProgress.View = View.Details;
            // 
            // btnMarkCompleted
            // 
            btnMarkCompleted.BackColor = Color.FromArgb(96, 125, 139);
            btnMarkCompleted.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMarkCompleted.ForeColor = Color.White;
            btnMarkCompleted.Location = new Point(46, 279);
            btnMarkCompleted.Name = "btnMarkCompleted";
            btnMarkCompleted.Size = new Size(234, 44);
            btnMarkCompleted.TabIndex = 1;
            btnMarkCompleted.Text = "Mark 1 Hour Completed";
            btnMarkCompleted.UseVisualStyleBackColor = false;
            btnMarkCompleted.Click += btnMarkCompleted_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(12, 380);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(72, 28);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(96, 125, 139);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(550, 279);
            button1.Name = "button1";
            button1.Size = new Size(203, 44);
            button1.TabIndex = 2;
            button1.Text = "Load Progress";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnLoadProgress_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(96, 125, 139);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(313, 279);
            button2.Name = "button2";
            button2.Size = new Size(203, 44);
            button2.TabIndex = 3;
            button2.Text = "Save Progress";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnSaveProgress_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(96, 125, 139);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(46, 329);
            button3.Name = "button3";
            button3.Size = new Size(164, 44);
            button3.TabIndex = 5;
            button3.Text = "Reset Progress";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnResetProgress_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 183, 77);
            panel1.Location = new Point(793, 269);
            panel1.Name = "panel1";
            panel1.Size = new Size(8, 150);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 183, 77);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 41);
            panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(287, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(332, 5);
            label1.Name = "label1";
            label1.Size = new Size(193, 32);
            label1.TabIndex = 0;
            label1.Text = "Progress Tracker";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 183, 77);
            panel3.Location = new Point(-1, 269);
            panel3.Name = "panel3";
            panel3.Size = new Size(8, 150);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 183, 77);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 419);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 8);
            panel4.TabIndex = 9;
            // 
            // ProgressTrackerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 239, 241);
            ClientSize = new Size(800, 427);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(lblStatus);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnMarkCompleted);
            Controls.Add(lvProgress);
            Name = "ProgressTrackerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProgressTrackerForm";
            WindowState = FormWindowState.Maximized;
            Load += ProgressTrackerForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvProgress;
        private Button btnMarkCompleted;
        private Label lblStatus;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private PictureBox pictureBox1;
    }
}