namespace GROUP_1X
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblEvent1;
        private System.Windows.Forms.TextBox txtEvent1;
        private System.Windows.Forms.Label lblEvent2;
        private System.Windows.Forms.TextBox txtEvent2;
        private System.Windows.Forms.Label lblEvent3;
        private System.Windows.Forms.TextBox txtEvent3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblEvent1 = new System.Windows.Forms.Label();
            this.txtEvent1 = new System.Windows.Forms.TextBox();
            this.lblEvent2 = new System.Windows.Forms.Label();
            this.txtEvent2 = new System.Windows.Forms.TextBox();
            this.lblEvent3 = new System.Windows.Forms.Label();
            this.txtEvent3 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblLowest = new System.Windows.Forms.Label();
            this.lblHighest = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(40, 35);
            this.lblStudentName.Text = "Student Name:";

            this.txtStudentName.Location = new System.Drawing.Point(150, 32);
            this.txtStudentName.Size = new System.Drawing.Size(250, 23);

            this.lblEvent1.AutoSize = true;
            this.lblEvent1.Location = new System.Drawing.Point(40, 80);
            this.lblEvent1.Text = "Event 1:";

            this.txtEvent1.Location = new System.Drawing.Point(150, 77);
            this.txtEvent1.Size = new System.Drawing.Size(100, 23);

            this.lblEvent2.AutoSize = true;
            this.lblEvent2.Location = new System.Drawing.Point(40, 120);
            this.lblEvent2.Text = "Event 2:";

            this.txtEvent2.Location = new System.Drawing.Point(150, 117);
            this.txtEvent2.Size = new System.Drawing.Size(100, 23);

            this.lblEvent3.AutoSize = true;
            this.lblEvent3.Location = new System.Drawing.Point(40, 160);
            this.lblEvent3.Text = "Event 3:";

            this.txtEvent3.Location = new System.Drawing.Point(150, 157);
            this.txtEvent3.Size = new System.Drawing.Size(100, 23);

            this.btnCalculate.Location = new System.Drawing.Point(40, 210);
            this.btnCalculate.Size = new System.Drawing.Size(100, 35);
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            this.btnClear.Location = new System.Drawing.Point(160, 210);
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(40, 275);
            this.lblAverage.Text = "Average:";

            this.lblLowest.AutoSize = true;
            this.lblLowest.Location = new System.Drawing.Point(40, 310);
            this.lblLowest.Text = "Lowest:";

            this.lblHighest.AutoSize = true;
            this.lblHighest.Location = new System.Drawing.Point(40, 345);
            this.lblHighest.Text = "Highest:";

            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(40, 380);
            this.lblResult.Text = "Result:";

            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblEvent1);
            this.Controls.Add(this.txtEvent1);
            this.Controls.Add(this.lblEvent2);
            this.Controls.Add(this.txtEvent2);
            this.Controls.Add(this.lblEvent3);
            this.Controls.Add(this.txtEvent3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblLowest);
            this.Controls.Add(this.lblHighest);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Student Grade Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
