using Algorithm;
using System;
using System.Collections.Generic;
using System.Drawing;
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

                    RefreshItems(items);
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
                    }

                    RefreshItems(items);
                }
                
            }

            FilledTextBox.Text = "";
        }

        private void DrawItems(List<SortedItem> items)
        {
            panel3.Controls.Clear();
            panel3.Refresh();

            foreach (var item in items)
            {
                panel3.Controls.Add(item.ProgressBar);
                panel3.Controls.Add(item.Label);
            }
            panel3.Refresh();
        }

        private void RefreshItems(List<SortedItem> items)
        {
            foreach (var item in items)
            {
                item.Refresh();
            }

            DrawItems(items);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BubleButton_Click(object sender, EventArgs e)
        {
            RefreshItems(items);

            var bubble = new BubbleSort<SortedItem>(items);
            bubble.CompareEvent += Bubble_CompareEvent;
            bubble.SwopEvent += Bubble_SwopEvent;
            var time = bubble.Sort();

            TimeLb.Text = "Время: " + time.Seconds + "s " + time.Milliseconds + " ms";
            SwopLb.Text = "Количество перестановок: " + bubble.SwopCount;
            CompareLb.Text = "Количество сравнений: " + bubble.ComparsionCount;
        }

        private void Bubble_SwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Number;
            e.Item1.SetNewPosition(e.Item2.Number);
            e.Item2.SetNewPosition(temp);
            panel3.Refresh();

            e.Item1.SetColor(Color.Green);
            e.Item2.SetColor(Color.Green);
            panel3.Refresh();
        }

        private void Bubble_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Blue);
            panel3.Refresh();
        }

        private void Swop(SortedItem a, SortedItem b)
        {
            a.SetColor(Color.Maroon);
            b.SetColor(Color.MidnightBlue);
        }
    }
}
