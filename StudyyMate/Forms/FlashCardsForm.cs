using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyyMate.Models;
using StudyyMate.Forms;
using System.Text.Json;
using System.IO;

namespace StudyyMate.Forms
{
    public partial class FlashCardsForm : Form
    {
        private List<Flashcard> flashcards = new List<Flashcard>();
        private readonly string flashcardsFile = "flashcards.json";
        public FlashCardsForm()
        {
            InitializeComponent();
            btnSave.Click += btnSave_Click;
            LoadFlashCardsFromFile();
        }

        private void LoadFlashCardsFromFile()
        {
            if (File.Exists(flashcardsFile))
            {
                string json = File.ReadAllText(flashcardsFile);
                List<Flashcard>? loaded = JsonSerializer.Deserialize<List<Flashcard>>(json);

                if (loaded != null)
                {
                    flashcards = loaded;

                    foreach (var flashcard in flashcards)
                    {
                        var item = new ListViewItem(flashcard.Question);
                        item.SubItems.Add(flashcard.Answer);
                        lvFlashcards.Items.Add(item);
                    }
                }
            }
        }

        private void FlashCardsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string question = txtQuestion.Text.Trim();
            string answer = txtAnswer.Text.Trim();

            if (string.IsNullOrEmpty(question) || string.IsNullOrEmpty(answer))
            {
                MessageBox.Show("Please enter both a question and an answer.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }


            
            Flashcard flashcard = new Flashcard(question, answer);
            flashcards.Add(flashcard);


            var item = new ListViewItem(new[] { flashcard.Question, flashcard.Answer });
            item.SubItems.Add(flashcard.Answer);
            lvFlashcards.Items.Add(item);

            string json = JsonSerializer.Serialize(flashcards, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(flashcardsFile, json);
            MessageBox.Show("Flashcard saved!");

            txtQuestion.Text = "";
            txtAnswer.Text = "";

        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvFlashcards.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a flashacard to delete.", "No selection");
                return;
            }


            //Get selected question (first column value)
            string selectedQuestion = lvFlashcards.SelectedItems[0].Text;

            //Remove from In-memory list.
            var cardToRemove = flashcards.FirstOrDefault(f => f.Question == selectedQuestion);
            if (cardToRemove != null)
            {
                flashcards.Remove(cardToRemove);
            }


            lvFlashcards.Items.Remove(lvFlashcards.SelectedItems[0]);

        
            string json = JsonSerializer.Serialize(flashcards, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(flashcardsFile, json);

            MessageBox.Show("Flashcard deleted.", "Success");

        }


        private void lvFlashcards_DoubleClick(object sender, EventArgs e)
        {
            if (lvFlashcards.SelectedItems.Count > 0)
            {
                string selectedQuestion = lvFlashcards.SelectedItems[0].Text;
                Flashcard? selected = flashcards.FirstOrDefault(f => f.Question == selectedQuestion);

                if (selected != null)
                {
                    txtQuestion.Text = selectedQuestion;
                    txtAnswer.Text = selected.Answer;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvFlashcards.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a flashcard to update");
                return;
            }
            string oldQuestion = lvFlashcards.SelectedItems[0].Text;
            Flashcard? cardToEdit = flashcards.FirstOrDefault(flashcards => flashcards.Question == oldQuestion);

            if (cardToEdit != null)
            {
                //Update flashcard object
                cardToEdit.Question = txtQuestion.Text.Trim();
                cardToEdit.Answer = txtAnswer.Text.Trim();

                //Update Listview display
                lvFlashcards.SelectedItems[0].Text = cardToEdit.Question;
                lvFlashcards.SelectedItems[0].SubItems[1].Text = cardToEdit.Answer;

                //Save updated list to json.
                string json = JsonSerializer.Serialize(flashcards, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(flashcardsFile, json);

                MessageBox.Show("Flashcard updated!", "Success");
                txtQuestion.Clear();
                txtAnswer.Clear();
            }
        }

        private void btnStartReview_Click(object sender, EventArgs e)
        {
            if (flashcards.Count == 0)
            {
                MessageBox.Show("No flashcards available to review.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var reviewForm = new FlashcardReviewForm(flashcards);
            reviewForm.ShowDialog();
        }
    }
}
