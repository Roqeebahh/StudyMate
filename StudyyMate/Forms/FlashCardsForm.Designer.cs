namespace StudyyMate.Forms
{
    partial class FlashCardsForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtQuestion = new TextBox();
            txtAnswer = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            lvFlashcards = new ListView();
            colQuestion = new ColumnHeader();
            colAnswer = new ColumnHeader();
            btnUpdate = new Button();
            btnStartReview = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 5);
            label1.Name = "label1";
            label1.Size = new Size(219, 32);
            label1.TabIndex = 0;
            label1.Text = "Create A Flashcard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(13, 58);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 1;
            label2.Text = "Question:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(13, 178);
            label3.Name = "label3";
            label3.Size = new Size(99, 32);
            label3.TabIndex = 2;
            label3.Text = "Answer:";
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(90, 90);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(505, 69);
            txtQuestion.TabIndex = 3;
            txtQuestion.Text = "nigeria flag";
            txtQuestion.TextChanged += txtQuestion_TextChanged;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(90, 210);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(505, 69);
            txtAnswer.TabIndex = 4;
            txtAnswer.Text = "green and white";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(96, 125, 139);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(29, 300);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 38);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(96, 125, 139);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(336, 300);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 38);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lvFlashcards
            // 
            lvFlashcards.Columns.AddRange(new ColumnHeader[] { colQuestion, colAnswer });
            lvFlashcards.FullRowSelect = true;
            lvFlashcards.GridLines = true;
            lvFlashcards.Location = new Point(13, 354);
            lvFlashcards.MultiSelect = false;
            lvFlashcards.Name = "lvFlashcards";
            lvFlashcards.Size = new Size(653, 172);
            lvFlashcards.TabIndex = 9;
            lvFlashcards.UseCompatibleStateImageBehavior = false;
            lvFlashcards.View = View.Details;
            lvFlashcards.DoubleClick += lvFlashcards_DoubleClick;
            // 
            // colQuestion
            // 
            colQuestion.Text = "Question";
            colQuestion.Width = 350;
            // 
            // colAnswer
            // 
            colAnswer.Text = "Answer";
            colAnswer.Width = 350;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(96, 125, 139);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(181, 300);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(123, 38);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnStartReview
            // 
            btnStartReview.BackColor = Color.FromArgb(96, 125, 139);
            btnStartReview.FlatStyle = FlatStyle.Flat;
            btnStartReview.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartReview.ForeColor = Color.White;
            btnStartReview.Location = new Point(489, 300);
            btnStartReview.Name = "btnStartReview";
            btnStartReview.Size = new Size(164, 38);
            btnStartReview.TabIndex = 12;
            btnStartReview.Text = "Start Review";
            btnStartReview.UseVisualStyleBackColor = false;
            btnStartReview.Click += btnStartReview_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 183, 77);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(670, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(8, 543);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 183, 77);
            panel2.Location = new Point(-3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 8);
            panel2.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 183, 77);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(8, 543);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 183, 77);
            panel5.Location = new Point(163, 534);
            panel5.Name = "panel5";
            panel5.Size = new Size(514, 8);
            panel5.TabIndex = 15;
            // 
            // FlashCardsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 239, 241);
            ClientSize = new Size(678, 543);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnStartReview);
            Controls.Add(btnUpdate);
            Controls.Add(lvFlashcards);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtAnswer);
            Controls.Add(txtQuestion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FlashCardsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flashcards";
            WindowState = FormWindowState.Maximized;
            Load += FlashCardsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtQuestion;
        private TextBox txtAnswer;
        private Button btnSave;
        private Button btnDelete;
        private ListView lvFlashcards;
        private ColumnHeader colQuestion;
        private ColumnHeader colAnswer;
        private Button btnUpdate;
        private Button btnStartReview;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
    }
}