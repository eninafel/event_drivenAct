namespace GenericCollectionActivity
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblStack;
        private System.Windows.Forms.ListBox lstStack;
        private System.Windows.Forms.Label lblCount;

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
            lblTitle = new System.Windows.Forms.Label();
            lblValue = new System.Windows.Forms.Label();
            txtValue = new System.Windows.Forms.TextBox();
            btnPush = new System.Windows.Forms.Button();
            btnPop = new System.Windows.Forms.Button();
            btnPeek = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            lblStack = new System.Windows.Forms.Label();
            lstStack = new System.Windows.Forms.ListBox();
            lblCount = new System.Windows.Forms.Label();
            SuspendLayout();

           
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(500, 520);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Stack Application";
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;

      
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                16F,
                System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(165, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(170, 30);
            lblTitle.Text = "STACK APPLICATION";

            
            lblValue.AutoSize = true;
            lblValue.Location = new System.Drawing.Point(55, 85);
            lblValue.Name = "lblValue";
            lblValue.Size = new System.Drawing.Size(70, 15);
            lblValue.Text = "Enter Value:";

            /
            txtValue.Location = new System.Drawing.Point(135, 82);
            txtValue.Name = "txtValue";
            txtValue.Size = new System.Drawing.Size(280, 23);

            btnPush.Location = new System.Drawing.Point(55, 125);
            btnPush.Name = "btnPush";
            btnPush.Size = new System.Drawing.Size(80, 35);
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += new System.EventHandler(btnPush_Click);

            btnPop.Location = new System.Drawing.Point(145, 125);
            btnPop.Name = "btnPop";
            btnPop.Size = new System.Drawing.Size(80, 35);
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += new System.EventHandler(btnPop_Click);

    
            btnPeek.Location = new System.Drawing.Point(235, 125);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new System.Drawing.Size(80, 35);
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += new System.EventHandler(btnPeek_Click);

       
            btnSearch.Location = new System.Drawing.Point(325, 125);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(90, 35);
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += new System.EventHandler(btnSearch_Click);

            
            btnClear.Location = new System.Drawing.Point(205, 175);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(90, 35);
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += new System.EventHandler(btnClear_Click);

         
            lblStack.AutoSize = true;
            lblStack.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold);
            lblStack.Location = new System.Drawing.Point(55, 235);
            lblStack.Name = "lblStack";
            lblStack.Size = new System.Drawing.Size(98, 19);
            lblStack.Text = "Stack Elements";

   
            lstStack.FormattingEnabled = true;
            lstStack.ItemHeight = 15;
            lstStack.Location = new System.Drawing.Point(55, 265);
            lstStack.Name = "lstStack";
            lstStack.Size = new System.Drawing.Size(360, 139);

            
            lblCount.AutoSize = true;
            lblCount.Location = new System.Drawing.Point(55, 430);
            lblCount.Name = "lblCount";
            lblCount.Size = new System.Drawing.Size(142, 15);
            lblCount.Text = "Number of Elements: 0";

         
            Controls.Add(lblTitle);
            Controls.Add(lblValue);
            Controls.Add(txtValue);
            Controls.Add(btnPush);
            Controls.Add(btnPop);
            Controls.Add(btnPeek);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(lblStack);
            Controls.Add(lstStack);
            Controls.Add(lblCount);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
