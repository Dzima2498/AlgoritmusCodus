using Algorithm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlgoritmusCodus
{
    public partial class Form1 : Form
    {
        List<SortedItem> items = new List<SortedItem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddTextBox.Text, out int value))
            {
                if (items.Count < 22)
                {
                    var item = new SortedItem(value, items.Count);
                    items.Add(item);
                    panel3.Controls.Add(item.ProgressBar);
                    panel3.Controls.Add(item.Label);
                }
            }

            AddTextBox.Text = "";
        }

        private void FilledButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(FilledTextBox.Text, out int value))
            {
                var rnd = new Random();
                if ((value > 0 && value < 22)&& ( items.Count + value < 22))
                {
                    for (int i = 0; i < value; i++)
                    {
                        SortedItem item = new SortedItem(rnd.Next(1, 1000), items.Count);
                        items.Add(item);
                        panel3.Controls.Add(item.ProgressBar);
                        panel3.Controls.Add(item.Label);
                    }
                }
                
            }

            FilledTextBox.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
