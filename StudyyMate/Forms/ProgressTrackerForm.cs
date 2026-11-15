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
using System.IO;


namespace StudyyMate.Forms
{
    public partial class ProgressTrackerForm : Form
    {
        private List<Subject> _subjects;
        private List<ProgressRecord> progressRecords = new List<ProgressRecord>();
        public ProgressTrackerForm(List<Subject> subjects = null)
        {
            InitializeComponent();
            _subjects = subjects;
        }


        private void RefreshListView()
        {
            lvProgress.Items.Clear();


            foreach (var record in progressRecords)
            {
                var item = new ListViewItem(record.SubjectName);
                item.SubItems.Add(record.TotalHours.ToString());
                item.SubItems.Add(record.HoursCompleted.ToString());

                double progress = (record.TotalHours == 0) ? 0 : (record.HoursCompleted * 100.0 / record.TotalHours);
                int percent = (int)Math.Round(progress);
                string progressVisual = GenerateProgressBar(percent);
                string percentText = $"{percent}%";

                item.SubItems.Add(progressVisual);
                item.SubItems.Add(percentText);
                lvProgress.Items.Add(item);
            }

        }

        private string GenerateProgressBar(int percent)
        {
            int blocks = percent / 10;
            return new string('█', blocks) + new string('░', 10 - blocks);
        }


        private void ProgressTrackerForm_Load(object sender, EventArgs e)
        {
            DatabaseHelper.InitializeDatabase();

            // Set up columns
            lvProgress.Columns.Clear();
            lvProgress.Columns.Add("Subject", 150);
            lvProgress.Columns.Add("Total Hours", 100);
            lvProgress.Columns.Add("Completed", 100);
            lvProgress.Columns.Add("Progress", 100);
            lvProgress.Columns.Add("", 70);

            lvProgress.View = View.Details;
            lvProgress.FullRowSelect = true;
            lvProgress.GridLines = true;

            try
            {
                progressRecords = DatabaseHelper.LoadProgress();

                // If no records in DB, and _subjects exist, initialize them
                if (_subjects != null && _subjects.Count > 0)
                    {
                    progressRecords = _subjects.Select(s => new ProgressRecord
                    {
                        SubjectName = s.Name,
                        TotalHours = int.TryParse(s.HoursPerWeek, out int h) ? h : 0,
                        HoursCompleted = 0
                    }).ToList();

                    DatabaseHelper.SaveProgress(progressRecords); // Save initial progress to DB
                }

                RefreshListView();
                lblStatus.Text = "STATUS: Progress loaded successfully from database.";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "STATUS: Error loading progress: " + ex.Message;
            }
        }


        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            if (lvProgress.SelectedItems.Count == 0)
            {
                lblStatus.Text = "STATUS: Please select a subject first.";
                return;
            }

            string selectedSubject = lvProgress.SelectedItems[0].Text;
            var record = progressRecords.FirstOrDefault(r => r.SubjectName == selectedSubject);

            if (record != null && record.HoursCompleted < record.TotalHours)
            {
                record.HoursCompleted++;
                RefreshListView();
                lblStatus.Text = $"STATUS: {record.SubjectName} marked: {record.HoursCompleted}/{record.TotalHours} completed.";
            }
            else
            {
                lblStatus.Text = "STATUS: Already completed or not found.";
            }
        }

        private void btnSaveProgress_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper.SaveProgress(progressRecords);
                lblStatus.Text = "STATUS: Progress saved successfully.";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "STATUS: Error saving progress: " + ex.Message;
            }
        }

        private void btnLoadProgress_Click(object sender, EventArgs e)
        {
            try
            {
                progressRecords = DatabaseHelper.LoadProgress(); // ✅ Load from SQLite
                RefreshListView();
                lblStatus.Text = "STATUS: Progress loaded successfully from database.";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "STATUS: Error loading progress: " + ex.Message;
            }
        }


        private void btnResetProgress_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will reset all progress and reload subjects from the timetable. Continue?",
                "Reset All", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                progressRecords.Clear();

                // Only rebuild if _subjects is valid
                if (_subjects != null && _subjects.Count > 0)
                {
                    foreach (var subj in _subjects)
                    {
                        progressRecords.Add(new ProgressRecord
                        {
                            SubjectName = subj.Name,
                            TotalHours = int.TryParse(subj.HoursPerWeek, out int h) ? h : 0,
                            HoursCompleted = 0
                        });
                    }

                    // Save the reset list to database
                    DatabaseHelper.SaveProgress(progressRecords);
                    RefreshListView();
                    lblStatus.Text = "STATUS: Progress reset and reloaded from timetable subjects.";
                }
                else
                {
                    lblStatus.Text = "STATUS: No subjects available to reset.";
                }
            }
        }



        private void btnUpdateProgress_Click(object sender, EventArgs e)
        {
            if (lvProgress.SelectedItems.Count > 0)
            {
                var index = lvProgress.SelectedItems[0].Index;
                if (index >= 0 && index < progressRecords.Count)
                {
                    var record = progressRecords[index];
                    if (record.HoursCompleted < record.TotalHours)
                    {
                        record.HoursCompleted++;

                        DatabaseHelper.SaveProgress(progressRecords); // Save after update
                        RefreshListView();
                        lblStatus.Text = $"STATUS: Marked 1 hour for {record.SubjectName}.";
                    }
                    else
                    {
                        lblStatus.Text = "STATUS: Already completed all hours.";
                    }
                }
            }
        }
    }
}

