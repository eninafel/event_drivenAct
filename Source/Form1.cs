using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GenericCollectionActivity
{
    public partial class Form1 : Form
    {
        public delegate void GradeEvaluationHandler(
            string studentName,
            string subject,
            double finalGrade,
            double lowest,
            double highest
        );

        public event GradeEvaluationHandler GradeEvaluated;

        private List<double> grades = new List<double>();

        public Form1()
        {
            InitializeComponent();

            GradeEvaluated += DisplayGradeResult;
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text.Trim();
            string subject = txtSubject.Text.Trim();

            double performanceTask;
            double quiz;
            double exam;

            if (string.IsNullOrWhiteSpace(studentName))
            {
                MessageBox.Show("Please enter the student name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(subject))
            {
                MessageBox.Show("Please enter the subject.");
                return;
            }

            if (!double.TryParse(txtPerformanceTask.Text, out performanceTask) ||
                !double.TryParse(txtQuiz.Text, out quiz) ||
                !double.TryParse(txtExam.Text, out exam))
            {
                MessageBox.Show("Please enter valid grades.");
                return;
            }

            if (performanceTask < 0 || performanceTask > 100 ||
                quiz < 0 || quiz > 100 ||
                exam < 0 || exam > 100)
            {
                MessageBox.Show("Grades must be between 0 and 100.");
                return;
            }

            grades.Clear();

            grades.Add(performanceTask);
            grades.Add(quiz);
            grades.Add(exam);

            double lowest = grades[0];
            double highest = grades[0];

            foreach (double grade in grades)
            {
                if (grade < lowest)
                {
                    lowest = grade;
                }

                if (grade > highest)
                {
                    highest = grade;
                }
            }

            double finalGrade =
                (performanceTask * 0.25) +
                (quiz * 0.25) +
                (exam * 0.50);

            GradeEvaluated?.Invoke(
                studentName,
                subject,
                finalGrade,
                lowest,
                highest
            );
        }

        private void DisplayGradeResult(
            string studentName,
            string subject,
            double finalGrade,
            double lowest,
            double highest
        )
        {
            lblStudentResult.Text = "Student: " + studentName;
            lblSubjectResult.Text = "Subject: " + subject;
            lblFinalGrade.Text = "Final Grade: " + finalGrade.ToString("0.00");
            lblLowest.Text = "Lowest Grade: " + lowest.ToString("0.00");
            lblHighest.Text = "Highest Grade: " + highest.ToString("0.00");

            if (finalGrade >= 69)
            {
                lblResult.Text = "Your grade in " + subject + " is " +
                                 finalGrade.ToString("0.00") + " - PASSED";
            }
            else
            {
                lblResult.Text = "Your grade in " + subject + " is " +
                                 finalGrade.ToString("0.00") + " - FAILED";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtSubject.Clear();
            txtPerformanceTask.Clear();
            txtQuiz.Clear();
            txtExam.Clear();

            grades.Clear();

            lblStudentResult.Text = "Student:";
            lblSubjectResult.Text = "Subject:";
            lblFinalGrade.Text = "Final Grade:";
            lblLowest.Text = "Lowest Grade:";
            lblHighest.Text = "Highest Grade:";
            lblResult.Text = "Your grade in this subject is:";

            txtStudentName.Focus();
        }
    }
}
