namespace StudyyMate.Forms
{
    partial class FlashcardReviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlashcardReviewForm));
            lblQuestion = new Label();
            lblAnswer = new Label();
            lblCounter = new Label();
            btnShowAnswer = new Button();
            btnNext = new Button();
            btnBack = new Button();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(25, 80);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(527, 79);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Sample Question?";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAnswer
            // 
            lblAnswer.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAnswer.Location = new Point(25, 174);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(527, 94);
            lblAnswer.TabIndex = 1;
            lblAnswer.Text = "label2";
            lblAnswer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCounter
            // 
            lblCounter.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCounter.Location = new Point(329, 279);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(126, 38);
            lblCounter.TabIndex = 2;
            lblCounter.Text = "Card 1 of X";
            lblCounter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnShowAnswer
            // 
            btnShowAnswer.BackColor = Color.FromArgb(96, 125, 139);
            btnShowAnswer.FlatStyle = FlatStyle.Flat;
            btnShowAnswer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAnswer.ForeColor = Color.White;
            btnShowAnswer.Location = new Point(18, 349);
            btnShowAnswer.Name = "btnShowAnswer";
            btnShowAnswer.Size = new Size(167, 34);
            btnShowAnswer.TabIndex = 3;
            btnShowAnswer.Text = "Show Answer\r\n";
            btnShowAnswer.UseVisualStyleBackColor = false;
            btnShowAnswer.Click += btnShowAnswer_Click_1;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(96, 125, 139);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(219, 349);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(167, 34);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next Flashcard";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click_1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(96, 125, 139);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(421, 349);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(128, 34);
            btnBack.TabIndex = 5;
            btnBack.Text = "Exit\r\n";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(189, 7);
            label1.Name = "label1";
            label1.Size = new Size(199, 32);
            label1.TabIndex = 6;
            label1.Text = "Flashcard Review";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 183, 77);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 46);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(142, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FlashcardReviewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 239, 241);
            ClientSize = new Size(578, 419);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(btnShowAnswer);
            Controls.Add(lblCounter);
            Controls.Add(lblAnswer);
            Controls.Add(lblQuestion);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FlashcardReviewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FlashcardReviewForm";
            WindowState = FormWindowState.Maximized;
            Load += FlashcardReviewForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblQuestion;
        private Label lblAnswer;
        private Label lblCounter;
        private Button btnShowAnswer;
        private Button btnNext;
        private Button btnBack;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}