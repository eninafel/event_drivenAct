using System;
using System.Windows.Forms;

namespace GenericCollectionActivity
{
    public partial class Form1 : Form
    {
        private Stack stack = new Stack();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value))
            {
                stack.Push(value);
                UpdateList();
                txtValue.Clear();
                txtValue.Focus();
            }
            else
            {
                MessageBox.Show(
                    "Please enter a valid number.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            int value = stack.Pop();

            if (value == -1)
            {
                MessageBox.Show(
                    "Stack is empty.",
                    "Pop",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Popped value: " + value,
                    "Pop",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                UpdateList();
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            int value = stack.Peek();

            if (value == -1)
            {
                MessageBox.Show(
                    "Stack is empty.",
                    "Peek",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Top value: " + value,
                    "Peek",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value))
            {
                if (stack.Search(value))
                {
                    MessageBox.Show(
                        value + " was found in the stack.",
                        "Search",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        value + " was not found in the stack.",
                        "Search",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    "Please enter a valid number.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            stack.Clear();
            UpdateList();
        }

        private void UpdateList()
        {
            lstStack.Items.Clear();

            for (int i = stack.GetItems().Count - 1; i >= 0; i--)
            {
                lstStack.Items.Add(stack.GetItems()[i]);
            }

            lblCount.Text = "Number of Elements: " + stack.Count();
        }
    }
}
