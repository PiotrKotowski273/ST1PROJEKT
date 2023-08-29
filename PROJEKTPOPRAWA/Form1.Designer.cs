
using System;

namespace PROJEKTPOPRAWA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddExpenseButton = new System.Windows.Forms.Button();
            this.RemoveExpenseButton = new System.Windows.Forms.Button();
            this.ShowTotalButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.expensesListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddExpenseButton
            // 
            this.AddExpenseButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.AddExpenseButton.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddExpenseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddExpenseButton.Location = new System.Drawing.Point(12, 102);
            this.AddExpenseButton.Name = "AddExpenseButton";
            this.AddExpenseButton.Size = new System.Drawing.Size(116, 53);
            this.AddExpenseButton.TabIndex = 0;
            this.AddExpenseButton.Text = "Dodaj Wydatek";
            this.AddExpenseButton.UseVisualStyleBackColor = false;
            this.AddExpenseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveExpenseButton
            // 
            this.RemoveExpenseButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.RemoveExpenseButton.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveExpenseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RemoveExpenseButton.Location = new System.Drawing.Point(134, 102);
            this.RemoveExpenseButton.Name = "RemoveExpenseButton";
            this.RemoveExpenseButton.Size = new System.Drawing.Size(107, 53);
            this.RemoveExpenseButton.TabIndex = 1;
            this.RemoveExpenseButton.Text = "Usuń Wydatek";
            this.RemoveExpenseButton.UseVisualStyleBackColor = false;
            this.RemoveExpenseButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ShowTotalButton
            // 
            this.ShowTotalButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.ShowTotalButton.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShowTotalButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowTotalButton.Location = new System.Drawing.Point(247, 102);
            this.ShowTotalButton.Name = "ShowTotalButton";
            this.ShowTotalButton.Size = new System.Drawing.Size(113, 53);
            this.ShowTotalButton.TabIndex = 2;
            this.ShowTotalButton.Text = "Pokaż Sume";
            this.ShowTotalButton.UseVisualStyleBackColor = false;
            this.ShowTotalButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.amountTextBox.Location = new System.Drawing.Point(77, 12);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(283, 23);
            this.amountTextBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.descriptionTextBox.Location = new System.Drawing.Point(77, 53);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(283, 23);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kwota :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Opis :";
            // 
            // expensesListBox
            // 
            this.expensesListBox.BackColor = System.Drawing.SystemColors.Info;
            this.expensesListBox.FormattingEnabled = true;
            this.expensesListBox.ItemHeight = 15;
            this.expensesListBox.Location = new System.Drawing.Point(12, 202);
            this.expensesListBox.Name = "expensesListBox";
            this.expensesListBox.Size = new System.Drawing.Size(348, 94);
            this.expensesListBox.TabIndex = 7;
            this.expensesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Historia Wydatków: ";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.Location = new System.Drawing.Point(12, 319);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(70, 22);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "SUMA :";
            this.totalLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 358);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.expensesListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.ShowTotalButton);
            this.Controls.Add(this.RemoveExpenseButton);
            this.Controls.Add(this.AddExpenseButton);
            this.Name = "Form1";
            this.Text = "Kalkulator Wydatków";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }



        #endregion

        public System.Windows.Forms.Button AddExpenseButton;
        public System.Windows.Forms.Button RemoveExpenseButton;
        public System.Windows.Forms.Button ShowTotalButton;
        public System.Windows.Forms.TextBox amountTextBox;
        public System.Windows.Forms.TextBox descriptionTextBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox expensesListBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label totalLabel;

    }
}

