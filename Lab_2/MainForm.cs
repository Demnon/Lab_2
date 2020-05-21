using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class MainForm : Form
    {
        // Работа с БЗ
        KnowledgeBase k_Base;
        // Данные нейросети (c матрицами весов)
        LayerNet[] l_LayersNet;
        public MainForm()
        {
            InitializeComponent();
            l_LayersNet = null;

            // Настройка внешнего вида таблицы
            d_InputTable.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            d_InputTable.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            d_OutputTable.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            d_OutputTable.DefaultCellStyle.Font = new Font("Times New Roman", 12);
        }

        // Подключение к бз и получение нейросети
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Получение пути к БЗ
            DataConnection d_DataConnection = new DataConnection();
            if (d_DataConnection.ShowDialog() != DialogResult.Cancel)
            {
                // Подключение к БЗ и получение данных
                k_Base = new KnowledgeBase(d_DataConnection.GetPath);
                k_Base.GetDataNet();
                l_LayersNet = k_Base.GetNet;
                // Формирование таблицы
                Table.OutputInfoInTables(d_InputTable, d_OutputTable, l_LayersNet);
            }
        }

        // Запуск работы сети
        private void runNetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Получение данных с формы
            double[] d_InputData = Table.GetInfoFromTable(d_InputTable);
            // Запуск сети
            JobNet j_JobNet = new JobNet(l_LayersNet, d_InputData);
            double[] d_OutputData = j_JobNet.RunNet();

            // Вывод результатов на форму
            Table.OutputInfoInTable(d_OutputData, d_OutputTable);
        }

        // Закрытие формы
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (k_Base != null)
            {
                k_Base.Dispose();
            }
            l_LayersNet = null;
            this.Close();
        }


        // Замена точки на запятую в ячейке
        private void d_InputTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < d_InputTable.Rows.Count && e.ColumnIndex>=0 && e.ColumnIndex <d_InputTable.Columns.Count)
            {
                d_InputTable[e.ColumnIndex, e.RowIndex].Value = d_InputTable[e.ColumnIndex, e.RowIndex].Value.ToString().Replace('.', ',');
            }
        }

        // Значение доступности и изменения должны быть 0 либо 1
        private void d_InputTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if ((d_InputTable[e.ColumnIndex-1,e.RowIndex].Value.ToString() == "Доступность узлов" 
                || d_InputTable[e.ColumnIndex - 1, e.RowIndex].Value.ToString() == "Изменение трафика") 
                && (d_InputTable[e.ColumnIndex, e.RowIndex].Value.ToString() != "0" 
                && d_InputTable[e.ColumnIndex, e.RowIndex].Value.ToString()!="1"))
            {
                MessageBox.Show("Параметр '" + d_InputTable[e.ColumnIndex - 1, e.RowIndex].Value.ToString() + "' должен иметь значения 0 или 1.");
            }
        }
    }
}
