namespace GROUP_1X
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblPerformanceTask;
        private System.Windows.Forms.TextBox txtPerformanceTask;
        private System.Windows.Forms.Label lblQuiz;
        private System.Windows.Forms.TextBox txtQuiz;
        private System.Windows.Forms.Label lblExam;
        private System.Windows.Forms.TextBox txtExam;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label lblStudentResult;
        private System.Windows.Forms.Label lblSubjectResult;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblLowest;
        private System.Windows.Forms.Label lblHighest;
        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblPerformanceTask = new System.Windows.Forms.Label();
            this.txtPerformanceTask = new System.Windows.Forms.TextBox();
            this.lblQuiz = new System.Windows.Forms.Label();
            this.txtQuiz = new System.Windows.Forms.TextBox();
            this.lblExam = new System.Windows.Forms.Label();
            this.txtExam = new System.Windows.Forms.TextBox();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblStudentResult = new System.Windows.Forms.Label();
            this.lblSubjectResult = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblLowest = new System.Windows.Forms.Label();
            this.lblHighest = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();

            this.grpInput.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                18F,
                System.Drawing.FontStyle.Bold
            );
            this.lblTitle.Location = new System.Drawing.Point(135, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(228, 32);
            this.lblTitle.Text = "Student Calculator";

            this.grpInput.Controls.Add(this.lblStudentName);
            this.grpInput.Controls.Add(this.txtStudentName);
            this.grpInput.Controls.Add(this.lblSubject);
            this.grpInput.Controls.Add(this.txtSubject);
            this.grpInput.Controls.Add(this.lblPerformanceTask);
            this.grpInput.Controls.Add(this.txtPerformanceTask);
            this.grpInput.Controls.Add(this.lblQuiz);
            this.grpInput.Controls.Add(this.txtQuiz);
            this.grpInput.Controls.Add(this.lblExam);
            this.grpInput.Controls.Add(this.txtExam);
            this.grpInput.Location = new System.Drawing.Point(30, 75);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(450, 260);
            this.grpInput.Text = "Student Information and Grade Evaluation";

            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(25, 35);
            this.lblStudentName.Text = "Student Name:";

            this.txtStudentName.Location = new System.Drawing.Point(150, 32);
            this.txtStudentName.Size = new System.Drawing.Size(250, 23);

            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(25, 75);
            this.lblSubject.Text = "Subject:";

            this.txtSubject.Location = new System.Drawing.Point(150, 72);
            this.txtSubject.Size = new System.Drawing.Size(250, 23);

            this.lblPerformanceTask.AutoSize = true;
            this.lblPerformanceTask.Location = new System.Drawing.Point(25, 120);
            this.lblPerformanceTask.Text = "Performance Task:";

            this.txtPerformanceTask.Location = new System.Drawing.Point(150, 117);
            this.txtPerformanceTask.Size = new System.Drawing.Size(250, 23);

            this.lblQuiz.AutoSize = true;
            this.lblQuiz.Location = new System.Drawing.Point(25, 160);
            this.lblQuiz.Text = "Quiz:";

            this.txtQuiz.Location = new System.Drawing.Point(150, 157);
            this.txtQuiz.Size = new System.Drawing.Size(250, 23);

            this.lblExam.AutoSize = true;
            this.lblExam.Location = new System.Drawing.Point(25, 200);
            this.lblExam.Text = "Exam:";

            this.txtExam.Location = new System.Drawing.Point(150, 197);
            this.txtExam.Size = new System.Drawing.Size(250, 23);

            this.btnEvaluate.Location = new System.Drawing.Point(90, 355);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(150, 40);
            this.btnEvaluate.Text = "Evaluate Grade";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);

            this.btnClear.Location = new System.Drawing.Point(270, 355);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 40);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.grpResults.Controls.Add(this.lblStudentResult);
            this.grpResults.Controls.Add(this.lblSubjectResult);
            this.grpResults.Controls.Add(this.lblAverage);
            this.grpResults.Controls.Add(this.lblLowest);
            this.grpResults.Controls.Add(this.lblHighest);
            this.grpResults.Controls.Add(this.lblResult);
            this.grpResults.Location = new System.Drawing.Point(30, 420);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(450, 230);
            this.grpResults.Text = "Grade Result";

            this.lblStudentResult.AutoSize = true;
            this.lblStudentResult.Location = new System.Drawing.Point(25, 30);
            this.lblStudentResult.Text = "Student:";

            this.lblSubjectResult.AutoSize = true;
            this.lblSubjectResult.Location = new System.Drawing.Point(25, 60);
            this.lblSubjectResult.Text = "Subject:";

            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(25, 90);
            this.lblAverage.Text = "Average:";

            this.lblLowest.AutoSize = true;
            this.lblLowest.Location = new System.Drawing.Point(25, 120);
            this.lblLowest.Text = "Lowest Grade:";

            this.lblHighest.AutoSize = true;
            this.lblHighest.Location = new System.Drawing.Point(25, 150);
            this.lblHighest.Text = "Highest Grade:";

            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold
            );
            this.lblResult.Location = new System.Drawing.Point(25, 185);
            this.lblResult.Text = "Your grade in this subject is:";

            this.ClientSize = new System.Drawing.Size(510, 680);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpResults);
            this.Name = "Form1";
            this.Text = "Student Calculator";

            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
