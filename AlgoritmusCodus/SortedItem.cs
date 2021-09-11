using System;
using System.Collections.Generic;
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
        public int Value { get; set; }
        public SortedItem(int value, int number)
        {
            Value = value;
            ProgressBar = new ProgressBar();
            Label = new Label();

            var y = number * 24;

            ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ProgressBar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            ProgressBar.Location = new System.Drawing.Point(84, y);
            ProgressBar.Name = "ProgressBar" + number;
            ProgressBar.Size = new System.Drawing.Size(146, 20);
            ProgressBar.TabIndex = number;
            ProgressBar.Maximum = 1000;
            ProgressBar.Minimum = 0;
            ProgressBar.Value = Value;

            // 
            // label3
            // 
            Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            Label.AutoSize = true;
            Label.Location = new System.Drawing.Point(22, y);
            Label.Name = "label"+ number;
            Label.Size = new System.Drawing.Size(50, 20);
            Label.TabIndex = number;
            Label.Text = Value.ToString();
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
    }
}
