using StudyyMate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyyMate.Forms
{
    public partial class FlashcardReviewForm : Form
    {
        private List<Flashcard> flashcards;
        private int currentIndex = 0;
        private bool answerVisible = false;

        public FlashcardReviewForm(List<Flashcard> flashcards)
        {
            InitializeComponent();
            this.flashcards = flashcards;
        }

        private void FlashcardReviewForm_Load(object sender, EventArgs e)
        {
            if (flashcards == null || flashcards.Count == 0)
            {
                MessageBox.Show("No flashcards available. Please add some in the Flashcards Manager.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }

            ShowCurrentCard();
        }

        private void ShowCurrentCard()
        {
            if (currentIndex >= 0 && currentIndex < flashcards.Count)
            {
                lblQuestion.Text = flashcards[currentIndex].Question;
                lblAnswer.Text = "";
                answerVisible = false;
                lblCounter.Text = $"Card {currentIndex + 1} of {flashcards.Count}";
            }
        }

        private void btnShowAnswer_Click_1(object sender, EventArgs e)
        {
            if (!answerVisible && currentIndex < flashcards.Count)
            {
                lblAnswer.Text = flashcards[currentIndex].Answer;
                answerVisible = true;
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {

            if (currentIndex < flashcards.Count - 1)
            {
                currentIndex++;
                ShowCurrentCard();
            }
            else
            {
                MessageBox.Show("End of flashcards.", "Done");
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
