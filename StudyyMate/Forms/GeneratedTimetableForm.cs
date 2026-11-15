using StudyyMate.Models;
using StudyyMate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace StudyyMate.Forms
{
    public partial class GeneratedTimetableForm : Form
    {
        private List<Subject> _subjects;
        public GeneratedTimetableForm(List<Subject> subjects)
        {
            InitializeComponent();
            _subjects = subjects;
        }

        public GeneratedTimetableForm()
        {
            InitializeComponent();
        }


        private void GeneratedTimetableForm_Load(object sender, EventArgs e)
        {
            // Setup columns
            lvTimetable.Columns.Add("Time Slot", 100);
            lvTimetable.Columns.Add("Monday", 135);
            lvTimetable.Columns.Add("Tuesday", 135);
            lvTimetable.Columns.Add("Wednesday", 135);
            lvTimetable.Columns.Add("Thursday", 135);
            lvTimetable.Columns.Add("Friday", 135);
            lvTimetable.DrawItem += lvTimetable_DrawItem;
            lvTimetable.DrawSubItem += lvTimetable_DrawSubItem;
            lvTimetable.DrawColumnHeader += lvTimetable_DrawColumnHeader;


         
            if (_subjects == null || _subjects.Count == 0)
            {
                MessageBox.Show("No subjects available to generate timetable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Define time slots
            string[] timeSlots = { "8-9", "9-10", "10-11", "11-12", "12-1", "1-2" };
            string[,] timetable = new string[6, 5];

            // Prepare subjects (priority sort optional)
            var sorted = _subjects.OrderByDescending(s => s.Priority).ToList();

            // Build subject entries according to hours
            List<Subject> subjectSlots = new List<Subject>();
            foreach (var subject in sorted)
            {
                int hours = int.Parse(subject.HoursPerWeek);
                for (int i = 0; i < hours; i++)
                {
                    subjectSlots.Add(subject);
                }
            }

            
            Random rng = new Random();
            subjectSlots = subjectSlots.OrderBy(x => rng.Next()).ToList();
            Queue<Subject> subjectQueue = new Queue<Subject>(subjectSlots);

            // Fill timetable
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (subjectQueue.Count > 0)
                    {
                        var nextSubject = subjectQueue.Dequeue();
                        timetable[row, col] = nextSubject.Name;
                    }
                }
            }

            // Display in ListView
            lvTimetable.Items.Clear();
            for (int row = 0; row < 6; row++)
            {
                var lvitem = new ListViewItem(timeSlots[row]);

                for (int col = 0; col < 5; col++)
                {
                    string value = timetable[row, col];
                    lvitem.SubItems.Add(string.IsNullOrEmpty(value) ? "-" : value);
                }

                lvTimetable.Items.Add(lvitem);
            }

            
            //lvTimetable.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            
            //int maxWidth = 150;
            //foreach (ColumnHeader column in lvTimetable.Columns)
            //{
            //    if (column.Width > maxWidth)
            //    {
            //        column.Width = maxWidth;
            //    }
            //}
        }

        private void lvTimetable_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (Font boldFont = new Font("Segoe UI", 9, FontStyle.Bold))
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.Header.Text, boldFont, e.Bounds, Color.Black);
            }
        }

        private void lvTimetable_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            // Leave empty to avoid flickering; drawing is handled in DrawSubItem
        }

        private void lvTimetable_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            string text = e.SubItem.Text;
            Font fontToUse;

            if (e.ColumnIndex == 0) // Time Slot column
            {
                fontToUse = new Font("Segoe UI", 9, FontStyle.Bold);
            }
            else if (!string.IsNullOrWhiteSpace(text) && text != "-") // Subject cell
            {
                fontToUse = new Font("Segoe UI", 9, FontStyle.Bold | FontStyle.Italic); // Simulated semi-bold
            }
            else
            {
                fontToUse = new Font("Segoe UI", 9, FontStyle.Regular);
            }

            e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            TextRenderer.DrawText(e.Graphics, text, fontToUse, e.Bounds, Color.Black, TextFormatFlags.Left);

            e.DrawBackground();
            if (e.ItemIndex % 2 == 0)
                e.Graphics.FillRectangle(new SolidBrush(Color.WhiteSmoke), e.Bounds);

            e.DrawText();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "timetable.json");
            List<List<string>> tableData = new List<List<string>>();

            foreach (ListViewItem item in lvTimetable.Items)
            {
                List<string> row = new List<string>();
                row.Add(item.Text); // Time slot
                for (int i = 1; i < item.SubItems.Count; i++)
                {
                    row.Add(item.SubItems[i].Text);
                }
                tableData.Add(row);
            }

            string json = JsonSerializer.Serialize(tableData, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);

            MessageBox.Show("Timetable saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvTimetable.Items.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}

 
