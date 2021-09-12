using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmusCodus
{
    public class SortedItem : IComparable
    {
        public ProgressBar ProgressBar { get; set; }
        public Label Label { get; private set; }
        public int Value { get; private set; }
        public int Number { get; private set; }
        public int StartNumber { get; private set; }
        public SortedItem(int value, int number)
        {
            Value = value;
            Number = number;
            StartNumber = number;
            ProgressBar = new ProgressBar();
            Label = new Label();

            var y = number * 24;

            ProgressBar.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            ProgressBar.ForeColor = Color.Green;
            ProgressBar.Location = new Point(84, y);
            ProgressBar.Name = "ProgressBar" + number;
            ProgressBar.Size = new Size(146, 20);
            ProgressBar.TabIndex = number;
            ProgressBar.Maximum = 1000;
            ProgressBar.Minimum = 0;
            ProgressBar.Value = Value;
            ProgressBar.Style = ProgressBarStyle.Continuous;

            // 
            // label3
            // 
            Label.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            Label.AutoSize = true;
            Label.Location = new Point(22, y);
            Label.Name = "label"+ number;
            Label.Size = new Size(50, 20);
            Label.TabIndex = number;
            Label.Text = Value.ToString();
        }

        public  void SetNewPosition (int num)
        {
            Number = num;
            var y = num * 24;
            ProgressBar.Location = new Point(84, y);
            ProgressBar.Name = "ProgressBar" + num;
            Label.Location = new Point(22, y);
            Label.Name = "label" + num;

        }
        public void Refresh()
        {
            Number = StartNumber;
            var y = Number * 24;
            ProgressBar.Location = new Point(84, y);
            ProgressBar.Name = "ProgressBar" + Number;
            Label.Location = new Point(22, y);
            Label.Name = "label" + Number;
        }

        public void SetColor (Color color)
        {
            ProgressBar.ForeColor = color;
        }
        public int CompareTo(object obj)
        {
            if(obj is SortedItem item)
            {
                return Value.CompareTo(item.Value);
            }
            else
            {
                throw new ArgumentException($"obj is not a {nameof(SortedItem)}", nameof(obj));
            }
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
