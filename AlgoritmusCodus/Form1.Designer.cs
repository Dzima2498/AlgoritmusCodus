
namespace AlgoritmusCodus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FilledTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FilledButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BubleButton = new System.Windows.Forms.Button();
            this.TimeLb = new System.Windows.Forms.Label();
            this.CompareLb = new System.Windows.Forms.Label();
            this.SwopLb = new System.Windows.Forms.Label();
            this.CocktailSortButton = new System.Windows.Forms.Button();
            this.InsertSortButton = new System.Windows.Forms.Button();
            this.CombSortButton = new System.Windows.Forms.Button();
            this.ShellSortButton = new System.Windows.Forms.Button();
            this.SelectionSortButton = new System.Windows.Forms.Button();
            this.HeapSortButton = new System.Windows.Forms.Button();
            this.GnomeSortButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TreeSortButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.AddTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 84);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить число:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(208, 32);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(10, 34);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(192, 27);
            this.AddTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Заполнить массив случайными числами";
            // 
            // FilledTextBox
            // 
            this.FilledTextBox.Location = new System.Drawing.Point(10, 34);
            this.FilledTextBox.Name = "FilledTextBox";
            this.FilledTextBox.Size = new System.Drawing.Size(124, 27);
            this.FilledTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.FilledButton);
            this.panel2.Controls.Add(this.FilledTextBox);
            this.panel2.Location = new System.Drawing.Point(353, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 84);
            this.panel2.TabIndex = 3;
            // 
            // FilledButton
            // 
            this.FilledButton.Location = new System.Drawing.Point(208, 32);
            this.FilledButton.Name = "FilledButton";
            this.FilledButton.Size = new System.Drawing.Size(94, 29);
            this.FilledButton.TabIndex = 1;
            this.FilledButton.Text = "Добавить";
            this.FilledButton.UseVisualStyleBackColor = true;
            this.FilledButton.Click += new System.EventHandler(this.FilledButton_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(743, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 509);
            this.panel3.TabIndex = 4;
            // 
            // BubleButton
            // 
            this.BubleButton.Location = new System.Drawing.Point(12, 150);
            this.BubleButton.Name = "BubleButton";
            this.BubleButton.Size = new System.Drawing.Size(146, 61);
            this.BubleButton.TabIndex = 5;
            this.BubleButton.Text = "Сортировка пузырьком";
            this.BubleButton.UseVisualStyleBackColor = true;
            this.BubleButton.Click += new System.EventHandler(this.BubleButton_Click);
            // 
            // TimeLb
            // 
            this.TimeLb.AutoSize = true;
            this.TimeLb.Location = new System.Drawing.Point(353, 118);
            this.TimeLb.Name = "TimeLb";
            this.TimeLb.Size = new System.Drawing.Size(61, 20);
            this.TimeLb.TabIndex = 6;
            this.TimeLb.Text = "Время: ";
            // 
            // CompareLb
            // 
            this.CompareLb.AutoSize = true;
            this.CompareLb.Location = new System.Drawing.Point(353, 150);
            this.CompareLb.Name = "CompareLb";
            this.CompareLb.Size = new System.Drawing.Size(177, 20);
            this.CompareLb.TabIndex = 7;
            this.CompareLb.Text = "Количество сравнений: ";
            // 
            // SwopLb
            // 
            this.SwopLb.AutoSize = true;
            this.SwopLb.Location = new System.Drawing.Point(353, 182);
            this.SwopLb.Name = "SwopLb";
            this.SwopLb.Size = new System.Drawing.Size(198, 20);
            this.SwopLb.TabIndex = 8;
            this.SwopLb.Text = "Количество перестановок: ";
            // 
            // CocktailSortButton
            // 
            this.CocktailSortButton.Location = new System.Drawing.Point(182, 151);
            this.CocktailSortButton.Name = "CocktailSortButton";
            this.CocktailSortButton.Size = new System.Drawing.Size(146, 60);
            this.CocktailSortButton.TabIndex = 9;
            this.CocktailSortButton.Text = "Шейкреная сортировка";
            this.CocktailSortButton.UseVisualStyleBackColor = true;
            this.CocktailSortButton.Click += new System.EventHandler(this.CocktailSortButton_Click);
            // 
            // InsertSortButton
            // 
            this.InsertSortButton.Location = new System.Drawing.Point(12, 232);
            this.InsertSortButton.Name = "InsertSortButton";
            this.InsertSortButton.Size = new System.Drawing.Size(145, 62);
            this.InsertSortButton.TabIndex = 10;
            this.InsertSortButton.Text = "Сортировка вставками";
            this.InsertSortButton.UseVisualStyleBackColor = true;
            this.InsertSortButton.Click += new System.EventHandler(this.InsertSortButton_Click);
            // 
            // CombSortButton
            // 
            this.CombSortButton.Location = new System.Drawing.Point(182, 232);
            this.CombSortButton.Name = "CombSortButton";
            this.CombSortButton.Size = new System.Drawing.Size(146, 62);
            this.CombSortButton.TabIndex = 11;
            this.CombSortButton.Text = "Сортировка гребешком";
            this.CombSortButton.UseVisualStyleBackColor = true;
            this.CombSortButton.Click += new System.EventHandler(this.CombSortButton_Click);
            // 
            // ShellSortButton
            // 
            this.ShellSortButton.Location = new System.Drawing.Point(12, 321);
            this.ShellSortButton.Name = "ShellSortButton";
            this.ShellSortButton.Size = new System.Drawing.Size(146, 62);
            this.ShellSortButton.TabIndex = 12;
            this.ShellSortButton.Text = "Сортировка Шелла";
            this.ShellSortButton.UseVisualStyleBackColor = true;
            this.ShellSortButton.Click += new System.EventHandler(this.ShellSortButton_Click);
            // 
            // SelectionSortButton
            // 
            this.SelectionSortButton.Location = new System.Drawing.Point(182, 321);
            this.SelectionSortButton.Name = "SelectionSortButton";
            this.SelectionSortButton.Size = new System.Drawing.Size(146, 61);
            this.SelectionSortButton.TabIndex = 13;
            this.SelectionSortButton.Text = "Сортировка выбором";
            this.SelectionSortButton.UseVisualStyleBackColor = true;
            this.SelectionSortButton.Click += new System.EventHandler(this.SelectionSortButton_Click);
            // 
            // HeapSortButton
            // 
            this.HeapSortButton.Location = new System.Drawing.Point(12, 404);
            this.HeapSortButton.Name = "HeapSortButton";
            this.HeapSortButton.Size = new System.Drawing.Size(145, 61);
            this.HeapSortButton.TabIndex = 14;
            this.HeapSortButton.Text = "Сортировка     кучей";
            this.HeapSortButton.UseVisualStyleBackColor = true;
            this.HeapSortButton.Click += new System.EventHandler(this.HeapSortButton_Click);
            // 
            // GnomeSortButton
            // 
            this.GnomeSortButton.Location = new System.Drawing.Point(182, 404);
            this.GnomeSortButton.Name = "GnomeSortButton";
            this.GnomeSortButton.Size = new System.Drawing.Size(146, 60);
            this.GnomeSortButton.TabIndex = 15;
            this.GnomeSortButton.Text = "Гномья сортировка";
            this.GnomeSortButton.UseVisualStyleBackColor = true;
            this.GnomeSortButton.Click += new System.EventHandler(this.GnomeSortButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(13, 491);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(94, 29);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // TreeSortButton
            // 
            this.TreeSortButton.Location = new System.Drawing.Point(353, 232);
            this.TreeSortButton.Name = "TreeSortButton";
            this.TreeSortButton.Size = new System.Drawing.Size(146, 62);
            this.TreeSortButton.TabIndex = 17;
            this.TreeSortButton.Text = "Сортировка деревом";
            this.TreeSortButton.UseVisualStyleBackColor = true;
            this.TreeSortButton.Click += new System.EventHandler(this.TreeSortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 533);
            this.Controls.Add(this.TreeSortButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.GnomeSortButton);
            this.Controls.Add(this.HeapSortButton);
            this.Controls.Add(this.SelectionSortButton);
            this.Controls.Add(this.ShellSortButton);
            this.Controls.Add(this.CombSortButton);
            this.Controls.Add(this.InsertSortButton);
            this.Controls.Add(this.CocktailSortButton);
            this.Controls.Add(this.SwopLb);
            this.Controls.Add(this.CompareLb);
            this.Controls.Add(this.TimeLb);
            this.Controls.Add(this.BubleButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Сортировка выбором";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FilledTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button FilledButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BubleButton;
        private System.Windows.Forms.Label TimeLb;
        private System.Windows.Forms.Label CompareLb;
        private System.Windows.Forms.Label SwopLb;
        private System.Windows.Forms.Button CocktailSortButton;
        private System.Windows.Forms.Button InsertSortButton;
        private System.Windows.Forms.Button CombSortButton;
        private System.Windows.Forms.Button ShellSortButton;
        private System.Windows.Forms.Button SelectionSortButton;
        private System.Windows.Forms.Button HeapSortButton;
        private System.Windows.Forms.Button GnomeSortButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button TreeSortButton;
    }
}

