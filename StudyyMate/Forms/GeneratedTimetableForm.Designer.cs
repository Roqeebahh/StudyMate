namespace StudyyMate.Forms
{
    partial class GeneratedTimetableForm 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratedTimetableForm));
            lvTimetable = new ListView();
            btnSave = new Button();
            btnClear = new Button();
            btnBack = new Button();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lvTimetable
            // 
            lvTimetable.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lvTimetable.FullRowSelect = true;
            lvTimetable.GridLines = true;
            lvTimetable.Location = new Point(12, 70);
            lvTimetable.Name = "lvTimetable";
            lvTimetable.OwnerDraw = true;
            lvTimetable.ShowGroups = false;
            lvTimetable.Size = new Size(698, 375);
            lvTimetable.TabIndex = 0;
            lvTimetable.UseCompatibleStateImageBehavior = false;
            lvTimetable.View = View.Details;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(96, 125, 139);
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(43, 460);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(181, 48);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(96, 125, 139);
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(268, 460);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(181, 48);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(96, 125, 139);
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(490, 460);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(181, 48);
            btnBack.TabIndex = 3;
            btnBack.Text = "Exit";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 8);
            label1.Name = "label1";
            label1.Size = new Size(241, 32);
            label1.TabIndex = 4;
            label1.Text = "Generated Timetable";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 183, 77);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 46);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(197, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 183, 77);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 529);
            panel2.Name = "panel2";
            panel2.Size = new Size(724, 22);
            panel2.TabIndex = 6;
            // 
            // GeneratedTimetableForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 551);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(lvTimetable);
            Name = "GeneratedTimetableForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GeneratedTimetableForm";
            WindowState = FormWindowState.Maximized;
            Load += GeneratedTimetableForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView lvTimetable;
        private Button btnSave;
        private Button btnClear;
        private Button btnBack;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}