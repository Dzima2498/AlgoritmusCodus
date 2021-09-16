using Algorithm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
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

                    RefreshItems();
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

                    RefreshItems();
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

        private void RefreshItems()
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

        private void Algorithm_SwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Number;
            e.Item1.SetNewPosition(e.Item2.Number);
            e.Item2.SetNewPosition(temp);
            panel3.Refresh();

            e.Item1.SetColor(Color.Green);
            e.Item2.SetColor(Color.Green);
            panel3.Refresh();
        }

        private void Algorithm_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Blue);
            panel3.Refresh();

            Thread.Sleep(15);

            e.Item1.SetColor(Color.Green);
            e.Item2.SetColor(Color.Green);
            panel3.Refresh();
        }

        private void Swop(SortedItem a, SortedItem b)
        {
            a.SetColor(Color.Maroon);
            b.SetColor(Color.MidnightBlue);
        }

        public void BtnCLick(AlgorithmBase<SortedItem> algorithm)
        {
            RefreshItems();

            algorithm.CompareEvent += Algorithm_CompareEvent;
            algorithm.SwopEvent += Algorithm_SwopEvent;
            var time = algorithm.Sort();

            TimeLb.Text = "Время: " + time.Seconds + "s " + time.Milliseconds + " ms";
            SwopLb.Text = "Количество перестановок: " + algorithm.SwopCount;
            CompareLb.Text = "Количество сравнений: " + algorithm.ComparsionCount;
        }


        private void BubleButton_Click(object sender, EventArgs e)
        {
            var bubble = new BubbleSort<SortedItem>(items);
            BtnCLick(bubble);
        }

        private void CocktailSortButton_Click(object sender, EventArgs e)
        {
            var cocktail = new CocktailSort<SortedItem>(items);
            BtnCLick(cocktail);
        }

        private void InsertSortButton_Click(object sender, EventArgs e)
        {
            var insert = new InsertSort<SortedItem>(items);
            BtnCLick(insert);
        }

        private void CombSortButton_Click(object sender, EventArgs e)
        {
            var comb = new CombSort<SortedItem>(items);
            BtnCLick(comb);
        }

        private void ShellSortButton_Click(object sender, EventArgs e)
        {
            var shell = new ShellSort<SortedItem>(items);
            BtnCLick(shell);
        }

        private void SelectionSortButton_Click(object sender, EventArgs e)
        {
            var selection = new SelectionSort<SortedItem>(items);
            BtnCLick(selection);
        }
    }
}
