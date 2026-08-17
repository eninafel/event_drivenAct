using System;
using System.Windows.Forms;

namespace GROUP_1X
{
    public partial class Form1 : Form
    {
        public delegate void GradeCalculationHandler(double average, double lowest, double highest);

        public event GradeCalculationHandler GradesCalculated;

        public Form1()
        {
            InitializeComponent();
            GradesCalculated += DisplayResults;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double event1;
            double event2;
            double event3;

            if (!double.TryParse(txtEvent1.Text, out event1) ||
                !double.TryParse(txtEvent2.Text, out event2) ||
                !double.TryParse(txtEvent3.Text, out event3))
            {
                MessageBox.Show("Please enter valid grades.");
                return;
            }

            if (event1 < 0 || event1 > 100 ||
                event2 < 0 || event2 > 100 ||
                event3 < 0 || event3 > 100)
            {
                MessageBox.Show("Grades must be between 0 and 100.");
                return;
            }

            double[] grades = { event1, event2, event3 };

            double total = 0;
            double lowest = grades[0];
            double highest = grades[0];

            foreach (double grade in grades)
            {
                total += grade;

                if (grade < lowest)
                    lowest = grade;

                if (grade > highest)
                    highest = grade;
            }

            double average = total / grades.Length;

            GradesCalculated?.Invoke(average, lowest, highest);
        }

        private void DisplayResults(double average, double lowest, double highest)
        {
            lblAverage.Text = "Average: " + average.ToString("0.00");
            lblLowest.Text = "Lowest: " + lowest.ToString("0.00");
            lblHighest.Text = "Highest: " + highest.ToString("0.00");

            if (average >= 75)
                lblResult.Text = "Result: PASSED";
            else
                lblResult.Text = "Result: FAILED";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtEvent1.Clear();
            txtEvent2.Clear();
            txtEvent3.Clear();

            lblAverage.Text = "Average:";
            lblLowest.Text = "Lowest:";
            lblHighest.Text = "Highest:";
            lblResult.Text = "Result:";
        }
    }
}
