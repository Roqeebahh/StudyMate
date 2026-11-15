using StudyyMate.Forms;
using StudyyMate.Models;
using System.Text.Json;

namespace StudyyMate
{
    public partial class MainForm : Form
    {
        private List<Subject> _subjects = new List<Subject>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("subjects.json"))
            {
                string json = File.ReadAllText("subjects.json");
                _subjects = JsonSerializer.Deserialize<List<Subject>>(json) ?? new List<Subject>();
            }
        }


        private void btnFlashcards_Click(object sender, EventArgs e)
        {
            var flashcardForm = new FlashCardsForm();
            flashcardForm.ShowDialog();
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            TimetableForm inputForm = new TimetableForm();
            inputForm.ShowDialog();
        }

        private void btnProgressTracker_Click(object sender, EventArgs e)
        {
            if (_subjects == null || !_subjects.Any())
            {
                    MessageBox.Show("No subjects loaded yet. Please create or load your timetable first.");
                    return;
            }
            
            var progressForm = new ProgressTrackerForm(_subjects);
            progressForm.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
