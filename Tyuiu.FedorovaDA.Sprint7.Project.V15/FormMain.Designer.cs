namespace Tyuiu.FedorovaDA.Sprint7.Project.V15
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            toolStrip1 = new ToolStrip();
            DevelopertoolStripButton_FDA = new ToolStripButton();
            toolStripSplitButtonFile_FDA = new ToolStripSplitButton();
            openToolStripMenuItem_FDA = new ToolStripMenuItem();
            saveToolStripMenuItem_FDA = new ToolStripMenuItem();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            AddRowToolStripMenuItem_FDA = new ToolStripMenuItem();
            AddColmsToolStripMenuItem_FDA = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            DeleteRowsToolStripMenuItem_FDA = new ToolStripMenuItem();
            DeleteColumsToolStripMenuItem_FDA = new ToolStripMenuItem();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            BuildCharttoolStripMenuItem_FDA = new ToolStripMenuItem();
            toolStripTextBoxInputColumnForChartName_FDA = new ToolStripTextBox();
            toolStripTextBoxInputColumnForChartData_FDA = new ToolStripTextBox();
            ProfitToolStripMenuItem_FDA = new ToolStripMenuItem();
            toolStripTextBoxInputColumnDohod_FDA = new ToolStripTextBox();
            CountDocumentsToolStripMenuItem_FDA = new ToolStripMenuItem();
            AverageToolStripMenuItem_FDA = new ToolStripMenuItem();
            toolStripTextBoxInputColumnAverageValue_FDA = new ToolStripTextBox();
            MaxSumToolStripMenuItem_FDA = new ToolStripMenuItem();
            toolStripTextBoxInputColumnMAX_FDA = new ToolStripTextBox();
            MinSumToolStripMenuItem_FDA = new ToolStripMenuItem();
            toolStripTextBoxInputColumnMIN_FDA = new ToolStripTextBox();
            ManualtoolStripButton_FDA = new ToolStripButton();
            panel_FDA = new Panel();
            buttonClear_FDA = new Button();
            Searchbutton_FDA = new Button();
            textBoxfilt_FDA = new TextBox();
            textBoxSearch_FDA = new TextBox();
            textBoxResult_FDA = new TextBox();
            textBoxResultTable_FDA = new TextBox();
            dataGridViewTable_FDA = new DataGridView();
            groupBox1 = new GroupBox();
            chart_FDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            openFileDialogTable_FDA = new OpenFileDialog();
            saveFileDialogTable_FDA = new SaveFileDialog();
            toolStrip1.SuspendLayout();
            panel_FDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_FDA).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_FDA).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { DevelopertoolStripButton_FDA, toolStripSplitButtonFile_FDA, toolStripDropDownButton1, ManualtoolStripButton_FDA });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(198, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // DevelopertoolStripButton_FDA
            // 
            DevelopertoolStripButton_FDA.DisplayStyle = ToolStripItemDisplayStyle.Image;
            DevelopertoolStripButton_FDA.Image = (Image)resources.GetObject("DevelopertoolStripButton_FDA.Image");
            DevelopertoolStripButton_FDA.ImageTransparentColor = Color.Magenta;
            DevelopertoolStripButton_FDA.Name = "DevelopertoolStripButton_FDA";
            DevelopertoolStripButton_FDA.Size = new Size(23, 22);
            DevelopertoolStripButton_FDA.Text = "toolStripButton1";
            DevelopertoolStripButton_FDA.Click += DevelopertoolStripButton_FDA_Click;
            // 
            // toolStripSplitButtonFile_FDA
            // 
            toolStripSplitButtonFile_FDA.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButtonFile_FDA.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem_FDA, saveToolStripMenuItem_FDA, добавитьToolStripMenuItem, удалитьToolStripMenuItem });
            toolStripSplitButtonFile_FDA.Font = new Font("Inter Tight", 9F);
            toolStripSplitButtonFile_FDA.Image = (Image)resources.GetObject("toolStripSplitButtonFile_FDA.Image");
            toolStripSplitButtonFile_FDA.ImageTransparentColor = Color.Magenta;
            toolStripSplitButtonFile_FDA.Name = "toolStripSplitButtonFile_FDA";
            toolStripSplitButtonFile_FDA.Size = new Size(53, 22);
            toolStripSplitButtonFile_FDA.Text = "Файл";
            // 
            // openToolStripMenuItem_FDA
            // 
            openToolStripMenuItem_FDA.Name = "openToolStripMenuItem_FDA";
            openToolStripMenuItem_FDA.Size = new Size(135, 22);
            openToolStripMenuItem_FDA.Text = "Открыть";
            openToolStripMenuItem_FDA.Click += openToolStripMenuItem_FDA_Click;
            // 
            // saveToolStripMenuItem_FDA
            // 
            saveToolStripMenuItem_FDA.Name = "saveToolStripMenuItem_FDA";
            saveToolStripMenuItem_FDA.Size = new Size(135, 22);
            saveToolStripMenuItem_FDA.Text = "Сохранить";
            saveToolStripMenuItem_FDA.Click += saveToolStripMenuItem_FDA_Click;
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddRowToolStripMenuItem_FDA, AddColmsToolStripMenuItem_FDA });
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(135, 22);
            добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // AddRowToolStripMenuItem_FDA
            // 
            AddRowToolStripMenuItem_FDA.Name = "AddRowToolStripMenuItem_FDA";
            AddRowToolStripMenuItem_FDA.Size = new Size(124, 22);
            AddRowToolStripMenuItem_FDA.Text = "Строчку";
            AddRowToolStripMenuItem_FDA.Click += AddRowToolStripMenuItem_Click;
            // 
            // AddColmsToolStripMenuItem_FDA
            // 
            AddColmsToolStripMenuItem_FDA.Name = "AddColmsToolStripMenuItem_FDA";
            AddColmsToolStripMenuItem_FDA.Size = new Size(124, 22);
            AddColmsToolStripMenuItem_FDA.Text = "Столбец";
            AddColmsToolStripMenuItem_FDA.Click += AddColmsToolStripMenuItem_FDA_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DeleteRowsToolStripMenuItem_FDA, DeleteColumsToolStripMenuItem_FDA });
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(135, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // DeleteRowsToolStripMenuItem_FDA
            // 
            DeleteRowsToolStripMenuItem_FDA.Name = "DeleteRowsToolStripMenuItem_FDA";
            DeleteRowsToolStripMenuItem_FDA.Size = new Size(124, 22);
            DeleteRowsToolStripMenuItem_FDA.Text = "Строчку";
            DeleteRowsToolStripMenuItem_FDA.Click += DeleteRowsToolStripMenuItem_FDA_Click;
            // 
            // DeleteColumsToolStripMenuItem_FDA
            // 
            DeleteColumsToolStripMenuItem_FDA.Name = "DeleteColumsToolStripMenuItem_FDA";
            DeleteColumsToolStripMenuItem_FDA.Size = new Size(124, 22);
            DeleteColumsToolStripMenuItem_FDA.Text = "Столбец";
            DeleteColumsToolStripMenuItem_FDA.Click += DeleteColumsToolStripMenuItem_FDA_Click;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { BuildCharttoolStripMenuItem_FDA, ProfitToolStripMenuItem_FDA, CountDocumentsToolStripMenuItem_FDA, AverageToolStripMenuItem_FDA, MaxSumToolStripMenuItem_FDA, MinSumToolStripMenuItem_FDA });
            toolStripDropDownButton1.Font = new Font("Inter Tight", 9F);
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(87, 22);
            toolStripDropDownButton1.Text = "Вычисления";
            // 
            // BuildCharttoolStripMenuItem_FDA
            // 
            BuildCharttoolStripMenuItem_FDA.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBoxInputColumnForChartName_FDA, toolStripTextBoxInputColumnForChartData_FDA });
            BuildCharttoolStripMenuItem_FDA.Name = "BuildCharttoolStripMenuItem_FDA";
            BuildCharttoolStripMenuItem_FDA.Size = new Size(248, 22);
            BuildCharttoolStripMenuItem_FDA.Text = "Построить график доходов";
            BuildCharttoolStripMenuItem_FDA.Click += BuildCharttoolStripMenuItem_FDA_Click;
            // 
            // toolStripTextBoxInputColumnForChartName_FDA
            // 
            toolStripTextBoxInputColumnForChartName_FDA.Name = "toolStripTextBoxInputColumnForChartName_FDA";
            toolStripTextBoxInputColumnForChartName_FDA.Size = new Size(180, 23);
            // 
            // toolStripTextBoxInputColumnForChartData_FDA
            // 
            toolStripTextBoxInputColumnForChartData_FDA.Name = "toolStripTextBoxInputColumnForChartData_FDA";
            toolStripTextBoxInputColumnForChartData_FDA.Size = new Size(240, 23);
            // 
            // ProfitToolStripMenuItem_FDA
            // 
            ProfitToolStripMenuItem_FDA.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBoxInputColumnDohod_FDA });
            ProfitToolStripMenuItem_FDA.Name = "ProfitToolStripMenuItem_FDA";
            ProfitToolStripMenuItem_FDA.Size = new Size(248, 22);
            ProfitToolStripMenuItem_FDA.Text = "Доход";
            ProfitToolStripMenuItem_FDA.Click += ProfitToolStripMenuItem_FDA_Click;
            // 
            // toolStripTextBoxInputColumnDohod_FDA
            // 
            toolStripTextBoxInputColumnDohod_FDA.Name = "toolStripTextBoxInputColumnDohod_FDA";
            toolStripTextBoxInputColumnDohod_FDA.Size = new Size(180, 23);
            // 
            // CountDocumentsToolStripMenuItem_FDA
            // 
            CountDocumentsToolStripMenuItem_FDA.Name = "CountDocumentsToolStripMenuItem_FDA";
            CountDocumentsToolStripMenuItem_FDA.Size = new Size(248, 22);
            CountDocumentsToolStripMenuItem_FDA.Text = "Счетчик договоров";
            CountDocumentsToolStripMenuItem_FDA.Click += CountDocumentsToolStripMenuItem_FDA_Click;
            // 
            // AverageToolStripMenuItem_FDA
            // 
            AverageToolStripMenuItem_FDA.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBoxInputColumnAverageValue_FDA });
            AverageToolStripMenuItem_FDA.Name = "AverageToolStripMenuItem_FDA";
            AverageToolStripMenuItem_FDA.Size = new Size(248, 22);
            AverageToolStripMenuItem_FDA.Text = "Среднее значение";
            AverageToolStripMenuItem_FDA.Click += AverageToolStripMenuItem_FDA_Click;
            // 
            // toolStripTextBoxInputColumnAverageValue_FDA
            // 
            toolStripTextBoxInputColumnAverageValue_FDA.Name = "toolStripTextBoxInputColumnAverageValue_FDA";
            toolStripTextBoxInputColumnAverageValue_FDA.Size = new Size(180, 23);
            // 
            // MaxSumToolStripMenuItem_FDA
            // 
            MaxSumToolStripMenuItem_FDA.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBoxInputColumnMAX_FDA });
            MaxSumToolStripMenuItem_FDA.Name = "MaxSumToolStripMenuItem_FDA";
            MaxSumToolStripMenuItem_FDA.Size = new Size(248, 22);
            MaxSumToolStripMenuItem_FDA.Text = "Максимальная сумма договора";
            MaxSumToolStripMenuItem_FDA.Click += MaxSumToolStripMenuItem_FDA_Click;
            // 
            // toolStripTextBoxInputColumnMAX_FDA
            // 
            toolStripTextBoxInputColumnMAX_FDA.Name = "toolStripTextBoxInputColumnMAX_FDA";
            toolStripTextBoxInputColumnMAX_FDA.Size = new Size(180, 23);
            // 
            // MinSumToolStripMenuItem_FDA
            // 
            MinSumToolStripMenuItem_FDA.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBoxInputColumnMIN_FDA });
            MinSumToolStripMenuItem_FDA.Name = "MinSumToolStripMenuItem_FDA";
            MinSumToolStripMenuItem_FDA.Size = new Size(248, 22);
            MinSumToolStripMenuItem_FDA.Text = "Минимальная сумма договора";
            MinSumToolStripMenuItem_FDA.Click += MinSumToolStripMenuItem_FDA_Click;
            // 
            // toolStripTextBoxInputColumnMIN_FDA
            // 
            toolStripTextBoxInputColumnMIN_FDA.Name = "toolStripTextBoxInputColumnMIN_FDA";
            toolStripTextBoxInputColumnMIN_FDA.Size = new Size(180, 23);
            // 
            // ManualtoolStripButton_FDA
            // 
            ManualtoolStripButton_FDA.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ManualtoolStripButton_FDA.Font = new Font("Inter Tight", 9F);
            ManualtoolStripButton_FDA.Image = (Image)resources.GetObject("ManualtoolStripButton_FDA.Image");
            ManualtoolStripButton_FDA.ImageTransparentColor = Color.Magenta;
            ManualtoolStripButton_FDA.Name = "ManualtoolStripButton_FDA";
            ManualtoolStripButton_FDA.Size = new Size(23, 22);
            ManualtoolStripButton_FDA.Text = "?";
            ManualtoolStripButton_FDA.Click += ManualtoolStripButton_FDA_Click;
            // 
            // panel_FDA
            // 
            panel_FDA.AccessibleRole = AccessibleRole.None;
            panel_FDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel_FDA.BackColor = Color.SteelBlue;
            panel_FDA.BackgroundImageLayout = ImageLayout.None;
            panel_FDA.Controls.Add(buttonClear_FDA);
            panel_FDA.Controls.Add(Searchbutton_FDA);
            panel_FDA.Controls.Add(textBoxfilt_FDA);
            panel_FDA.Controls.Add(textBoxSearch_FDA);
            panel_FDA.Controls.Add(textBoxResult_FDA);
            panel_FDA.Controls.Add(textBoxResultTable_FDA);
            panel_FDA.ForeColor = SystemColors.ControlLightLight;
            panel_FDA.Location = new Point(0, -1);
            panel_FDA.Name = "panel_FDA";
            panel_FDA.Size = new Size(185, 603);
            panel_FDA.TabIndex = 3;
            // 
            // buttonClear_FDA
            // 
            buttonClear_FDA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonClear_FDA.Font = new Font("Inter Tight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonClear_FDA.ForeColor = SystemColors.ActiveCaptionText;
            buttonClear_FDA.Location = new Point(12, 566);
            buttonClear_FDA.Name = "buttonClear_FDA";
            buttonClear_FDA.Size = new Size(121, 23);
            buttonClear_FDA.TabIndex = 9;
            buttonClear_FDA.Text = "Закрыть таблицу";
            buttonClear_FDA.UseVisualStyleBackColor = true;
            buttonClear_FDA.Click += buttonClear_FDA_Click;
            // 
            // Searchbutton_FDA
            // 
            Searchbutton_FDA.BackgroundImageLayout = ImageLayout.Center;
            Searchbutton_FDA.FlatStyle = FlatStyle.System;
            Searchbutton_FDA.Font = new Font("Inter Tight", 9F);
            Searchbutton_FDA.ForeColor = Color.AliceBlue;
            Searchbutton_FDA.Location = new Point(121, 147);
            Searchbutton_FDA.Name = "Searchbutton_FDA";
            Searchbutton_FDA.Size = new Size(52, 20);
            Searchbutton_FDA.TabIndex = 8;
            Searchbutton_FDA.Text = "Поиск";
            Searchbutton_FDA.UseVisualStyleBackColor = true;
            Searchbutton_FDA.Click += Searchbutton_Click;
            // 
            // textBoxfilt_FDA
            // 
            textBoxfilt_FDA.BackColor = Color.SteelBlue;
            textBoxfilt_FDA.BorderStyle = BorderStyle.None;
            textBoxfilt_FDA.Font = new Font("Inter Tight", 9.75F);
            textBoxfilt_FDA.ForeColor = SystemColors.Info;
            textBoxfilt_FDA.Location = new Point(15, 125);
            textBoxfilt_FDA.Name = "textBoxfilt_FDA";
            textBoxfilt_FDA.ReadOnly = true;
            textBoxfilt_FDA.Size = new Size(100, 16);
            textBoxfilt_FDA.TabIndex = 5;
            textBoxfilt_FDA.Text = "Фильтр";
            // 
            // textBoxSearch_FDA
            // 
            textBoxSearch_FDA.BorderStyle = BorderStyle.None;
            textBoxSearch_FDA.Font = new Font("Segoe UI", 9.75F);
            textBoxSearch_FDA.Location = new Point(15, 149);
            textBoxSearch_FDA.Name = "textBoxSearch_FDA";
            textBoxSearch_FDA.Size = new Size(100, 18);
            textBoxSearch_FDA.TabIndex = 4;
            // 
            // textBoxResult_FDA
            // 
            textBoxResult_FDA.BackColor = Color.SteelBlue;
            textBoxResult_FDA.BorderStyle = BorderStyle.None;
            textBoxResult_FDA.Font = new Font("Inter Tight", 9.75F);
            textBoxResult_FDA.ForeColor = SystemColors.Info;
            textBoxResult_FDA.Location = new Point(12, 50);
            textBoxResult_FDA.Name = "textBoxResult_FDA";
            textBoxResult_FDA.ReadOnly = true;
            textBoxResult_FDA.Size = new Size(152, 16);
            textBoxResult_FDA.TabIndex = 2;
            textBoxResult_FDA.Text = "Результат вычислений";
            // 
            // textBoxResultTable_FDA
            // 
            textBoxResultTable_FDA.BorderStyle = BorderStyle.None;
            textBoxResultTable_FDA.Font = new Font("Segoe UI", 9.75F);
            textBoxResultTable_FDA.Location = new Point(12, 72);
            textBoxResultTable_FDA.Name = "textBoxResultTable_FDA";
            textBoxResultTable_FDA.ReadOnly = true;
            textBoxResultTable_FDA.Size = new Size(100, 18);
            textBoxResultTable_FDA.TabIndex = 2;
            // 
            // dataGridViewTable_FDA
            // 
            dataGridViewTable_FDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTable_FDA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTable_FDA.BackgroundColor = SystemColors.ControlLight;
            dataGridViewTable_FDA.BorderStyle = BorderStyle.None;
            dataGridViewTable_FDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTable_FDA.Location = new Point(191, 28);
            dataGridViewTable_FDA.Name = "dataGridViewTable_FDA";
            dataGridViewTable_FDA.Size = new Size(751, 560);
            dataGridViewTable_FDA.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(chart_FDA);
            groupBox1.Font = new Font("Inter Tight", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(948, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 560);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "График сведений";
            // 
            // chart_FDA
            // 
            chartArea2.Name = "ChartArea1";
            chart_FDA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart_FDA.Legends.Add(legend2);
            chart_FDA.Location = new Point(20, 30);
            chart_FDA.Name = "chart_FDA";
            chart_FDA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart_FDA.Series.Add(series2);
            chart_FDA.Size = new Size(423, 362);
            chart_FDA.TabIndex = 0;
            chart_FDA.Text = "chart1";
            // 
            // openFileDialogTable_FDA
            // 
            openFileDialogTable_FDA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 600);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewTable_FDA);
            Controls.Add(toolStrip1);
            Controls.Add(panel_FDA);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            Text = "ДДО";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel_FDA.ResumeLayout(false);
            panel_FDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_FDA).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart_FDA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton DevelopertoolStripButton_FDA;
        private ToolStripSplitButton toolStripSplitButtonFile_FDA;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem BuildCharttoolStripMenuItem_FDA;
        private ToolStripButton ManualtoolStripButton_FDA;
        private Panel panel_FDA;
        private Button Searchbutton_FDA;
        private TextBox textBoxfilt_FDA;
        private TextBox textBoxSearch_FDA;
        private TextBox textBoxResult_FDA;
        private TextBox textBoxResultTable_FDA;
        private DataGridView dataGridViewTable_FDA;
        private GroupBox groupBox1;
        private ToolStripMenuItem openToolStripMenuItem_FDA;
        private ToolStripMenuItem saveToolStripMenuItem_FDA;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem AddRowToolStripMenuItem_FDA;
        private ToolStripMenuItem AddColmsToolStripMenuItem_FDA;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem DeleteRowsToolStripMenuItem_FDA;
        private ToolStripMenuItem DeleteColumsToolStripMenuItem_FDA;
        private ToolStripMenuItem ProfitToolStripMenuItem_FDA;
        private ToolStripMenuItem CountDocumentsToolStripMenuItem_FDA;
        private ToolStripMenuItem AverageToolStripMenuItem_FDA;
        private ToolStripMenuItem MaxSumToolStripMenuItem_FDA;
        private ToolStripMenuItem MinSumToolStripMenuItem_FDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_FDA;
        private OpenFileDialog openFileDialogTable_FDA;
        private SaveFileDialog saveFileDialogTable_FDA;
        private Button buttonClear_FDA;
        private ToolStripTextBox toolStripTextBoxInputColumnDohod_FDA;
        private ToolStripTextBox toolStripTextBoxInputColumnMAX_FDA;
        private ToolStripTextBox toolStripTextBoxInputColumnMIN_FDA;
        private ToolStripTextBox toolStripTextBoxInputColumnAverageValue_FDA;
        private ToolStripTextBox toolStripTextBoxInputColumnForChartName_FDA;
        private ToolStripTextBox toolStripTextBoxInputColumnForChartData_FDA;
    }
}
