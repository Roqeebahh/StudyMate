using StudyyMate.Forms;
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
    public partial class TimetableForm : Form
    {
        private List<Subject> _subjects = new List<Subject>();

        public TimetableForm()
        {
            InitializeComponent();

            lvSubjects.View = View.Details;
            lvSubjects.FullRowSelect = true;
            lvSubjects.Columns.Clear();
            lvSubjects.Columns.Add("Subject", 130);
            lvSubjects.Columns.Add("Hours/Week", 130);
            lvSubjects.Columns.Add("Priority", 80);
        }

        private void TimetableForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            string subjectName = txtSubjectName.Text.Trim();
            int hours = (int)nudHours.Value;
            int priority = (int)nudPriority.Value;

            if (string.IsNullOrEmpty(subjectName) || hours <= 0)
            {
                MessageBox.Show("Please enter a valid subject and hour.");
                return;
            }

            //Add to ListView
            var item = new ListViewItem(subjectName);
            item.SubItems.Add(hours.ToString());
            item.SubItems.Add(priority.ToString());

            lvSubjects.Items.Add(item);

            txtSubjectName.Clear();
            nudHours.Value = 1;
            nudPriority.Value = 1;


        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (lvSubjects.Items.Count == 0)
            {
                MessageBox.Show("Add some subjects first!");
                return;
            }

            //Collect subject data
            var subjects = new List<Subject>();

            foreach (ListViewItem item in lvSubjects.Items)
            {
                subjects.Add(new Subject
                {
                    Name = item.SubItems[0].Text,
                    HoursPerWeek = item.SubItems[1].Text,
                    Priority = item.SubItems[2].Text,

                });
            }
            _subjects = subjects.ToList();

            string json = JsonSerializer.Serialize(_subjects);
            File.WriteAllText("subjects.json", json);

            //Open timetable viewer form
            var viewer = new GeneratedTimetableForm(subjects);
            viewer.ShowDialog();



        }
    }
}
