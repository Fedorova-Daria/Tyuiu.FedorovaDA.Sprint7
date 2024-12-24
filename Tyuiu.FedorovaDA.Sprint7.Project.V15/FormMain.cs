using System.Text;
using Tyuiu.FedorovaDA.Sprint7.Project.V15.Lib;
namespace Tyuiu.FedorovaDA.Sprint7.Project.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        int cols, rows;


        private void openToolStripMenuItem_FDA_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTable_FDA.ShowDialog();
                openFilePath = openFileDialogTable_FDA.FileName;

                string[,] arrayValues = ds.LoadFromFileData(openFilePath);
                dataGridViewTable_FDA.ColumnCount = cols = arrayValues.GetLength(1);
                dataGridViewTable_FDA.RowCount = rows = arrayValues.GetLength(0);

                for (int i = 0; i < cols; i++)
                {
                    dataGridViewTable_FDA.Columns[i].Name = arrayValues[0, i];
                }


                for (int i = 1; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dataGridViewTable_FDA[j, i - 1].Value = arrayValues[i, j];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали файл!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_FDA_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogTable_FDA.FileName = "DataBase.csv";
                saveFileDialogTable_FDA.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogTable_FDA.ShowDialog();

                string path = saveFileDialogTable_FDA.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                if (fileExists)
                {
                    File.Delete(path);
                }

                int rows = dataGridViewTable_FDA.RowCount;
                int columns = dataGridViewTable_FDA.ColumnCount;
                string header = "";
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        header += dataGridViewTable_FDA.Columns[j].HeaderText + ";";
                    }
                    else
                    {
                        header += dataGridViewTable_FDA.Columns[j].HeaderText;
                    }
                }
                File.AppendAllText(path, header + Environment.NewLine, Encoding.UTF8);


                for (int i = 0; i < rows; i++)
                {
                    string str = "";
                    for (int j = 0; j < columns; j++)
                    {

                        if (j != columns - 1)
                        {
                            str += dataGridViewTable_FDA.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str += dataGridViewTable_FDA.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine, Encoding.UTF8);
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonClear_FDA_Click(object sender, EventArgs e)
        {
            this.dataGridViewTable_FDA.Rows.Clear();
            this.dataGridViewTable_FDA.Columns.Clear();
        }

        private void AddRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewTable_FDA.Columns.Count == 0)
            {
                MessageBox.Show("Сначала добавьте столбцы!", "Сообщение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridViewTable_FDA.Rows.Add();
            }
        }

        private void AddColmsToolStripMenuItem_FDA_Click(object sender, EventArgs e)
        {
            FormColums formWriteText = new FormColums();
            formWriteText.ShowDialog();

            DataGridViewColumn column = new DataGridViewTextBoxColumn();// инициализируем колонку
            column.DataPropertyName = "Name";//имя
            column.Name = DataService.Text; //заголовок колонки
            dataGridViewTable_FDA.Columns.Add(column);
        }

        private void DevelopertoolStripButton_FDA_Click(object sender, EventArgs e)
        {
            AboutMe formAboutDeveloper = new AboutMe();
            formAboutDeveloper.ShowDialog();
        }

        private void DeleteRowsToolStripMenuItem_FDA_Click(object sender, EventArgs e)
        {
            if (dataGridViewTable_FDA.CurrentRow != null)
            {
                dataGridViewTable_FDA.Rows.Remove(dataGridViewTable_FDA.CurrentRow);
            }
        }

        private void DeleteColumsToolStripMenuItem_FDA_Click(object sender, EventArgs e)
        {
            int CellCount = dataGridViewTable_FDA.Columns.Count - 1;
            dataGridViewTable_FDA.Columns.Remove(dataGridViewTable_FDA.Columns[CellCount]);
        }

        private void ProfitToolStripMenuItem_FDA_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = Convert.ToInt32(toolStripTextBoxInputColumnDohod_FDA.Text);
                columnIndex -= 1;
                toolStripTextBoxInputColumnDohod_FDA.Clear();

                // Создаем массив для хранения данных из столбца
                double[] columnData = new double[dataGridViewTable_FDA.Rows.Count];

                // Используем цикл для записи данных из столбца в массив
                for (int i = 0; i < dataGridViewTable_FDA.Rows.Count; i++)
                {
                    columnData[i] = Convert.ToDouble(dataGridViewTable_FDA.Rows[i].Cells[columnIndex].Value);
                }

                double res = ds.SummDohod(columnData);
                textBoxResultTable_FDA.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Сначала введите номер столбца в раскрывающемся поле операции!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MinSumToolStripMenuItem_FDA_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = Convert.ToInt32(toolStripTextBoxInputColumnMIN_FDA.Text);
                columnIndex -= 1;
                toolStripTextBoxInputColumnMIN_FDA.Clear();

                double[] columnData = new double[dataGridViewTable_FDA.Rows.Count];

                for (int i = 0; i < dataGridViewTable_FDA.Rows.Count; i++)
                {
                    columnData[i] = Convert.ToDouble(dataGridViewTable_FDA.Rows[i].Cells[columnIndex].Value);
                }

                double res = ds.MinDohod(columnData);
                textBoxResultTable_FDA.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Сначала введите номер столбца в раскрывающемся поле операции!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MaxSumToolStripMenuItem_FDA_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = Convert.ToInt32(toolStripTextBoxInputColumnMAX_FDA.Text);
                columnIndex -= 1;
                toolStripTextBoxInputColumnMAX_FDA.Clear();

                double[] columnData = new double[dataGridViewTable_FDA.Rows.Count];

                for (int i = 0; i < dataGridViewTable_FDA.Rows.Count; i++)
                {
                    columnData[i] = Convert.ToInt32(dataGridViewTable_FDA.Rows[i].Cells[columnIndex].Value);
                }

                double res = ds.MaxDohod(columnData);
                textBoxResultTable_FDA.Text = Convert.ToString(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AverageToolStripMenuItem_FDA_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = Convert.ToInt32(toolStripTextBoxInputColumnAverageValue_FDA.Text);
                columnIndex -= 1;
                toolStripTextBoxInputColumnAverageValue_FDA.Clear();

                double[] columnData = new double[dataGridViewTable_FDA.Rows.Count];

                for (int i = 0; i < dataGridViewTable_FDA.Rows.Count; i++)
                {
                    columnData[i] = Convert.ToInt32(dataGridViewTable_FDA.Rows[i].Cells[columnIndex].Value);
                }

                double res = ds.AverageValue(columnData);
                textBoxResultTable_FDA.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Сначала введите номер столбца в раскрывающемся поле операции!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CountDocumentsToolStripMenuItem_FDA_Click(object sender, EventArgs e)
        {
            try
            {
                
                int rowCount = dataGridViewTable_FDA.Rows.Count;
                rowCount -= 1;
                textBoxResultTable_FDA.Text = rowCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuildCharttoolStripMenuItem_FDA_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndexName = Convert.ToInt32(toolStripTextBoxInputColumnForChartName_FDA.Text);
                columnIndexName -= 1;
                toolStripTextBoxInputColumnForChartName_FDA.Clear();

                string[] columnDataName = new string[dataGridViewTable_FDA.Rows.Count];
                for (int i = 0; i < dataGridViewTable_FDA.Rows.Count; i++)
                {
                    columnDataName[i] = Convert.ToString(dataGridViewTable_FDA.Rows[i].Cells[columnIndexName].Value);
                }

                //

                int columnIndexData = Convert.ToInt32(toolStripTextBoxInputColumnForChartData_FDA.Text);
                columnIndexData -= 1;
                toolStripTextBoxInputColumnForChartData_FDA.Clear();

                double[] columnData = new double[dataGridViewTable_FDA.Rows.Count];
                for (int i = 0; i < dataGridViewTable_FDA.Rows.Count; i++)
                {
                    columnData[i] = Convert.ToDouble(dataGridViewTable_FDA.Rows[i].Cells[columnIndexData].Value);
                }

                DataService.ArrayData = columnData;
                DataService.ArrayName = columnDataName;
                string[] arrayname = DataService.ArrayName;
                double[] arraydata = DataService.ArrayData;

                this.chart_FDA.Series[0].Points.DataBindXY(arrayname, arraydata);

            }
            catch
            {
                MessageBox.Show("Что-то пошло не так!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            if (textBoxSearch_FDA != null)
            {
                string currentText = textBoxSearch_FDA.Text;
                foreach (DataGridViewRow row in dataGridViewTable_FDA.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && textBoxSearch_FDA.Text != string.Empty && cell.Value.ToString().Contains(textBoxSearch_FDA.Text))
                        {
                            cell.Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            cell.Style.BackColor = Color.White;
                        }
                    }
                }
            }
        }



        private void ManualtoolStripButton_FDA_Click(object sender, EventArgs e)
        {
            FormManual formManual = new FormManual();
            formManual.Show();
        }

        
    }
}
