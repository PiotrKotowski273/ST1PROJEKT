using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKTPOPRAWA
{
    public partial class Form1 : Form
    {
        public List<decimal> expenses = new List<decimal>();
        public List<string> descriptions = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(amountTextBox.Text, out decimal amount))
            {
                expenses.Add(amount);
                descriptions.Add(descriptionTextBox.Text);
                UpdateExpensesList();
            }
            else
            {
                MessageBox.Show("Niepoprawna kwota wydatku.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (expensesListBox.SelectedIndex >= 0)
            {
                expenses.RemoveAt(expensesListBox.SelectedIndex);
                UpdateExpensesList();
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        public void UpdateExpensesList()
        {
            expensesListBox.Items.Clear();
            for (int i = 0; i < expenses.Count; i++)
            {
                string expenseText = $"Wydatek: {expenses[i]:C} - {descriptions[i]}";
                expensesListBox.Items.Add(expenseText);
            }
        }

        public void CalculateTotal()
        {
            decimal total = 0;
            foreach (decimal expense in expenses)
            {
                total += expense;
            }
            totalLabel.Text = $"SUMA: {total:C}";
        }

    }
}