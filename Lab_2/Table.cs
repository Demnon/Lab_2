using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    // Работа с таблицей
    public static class Table
    {
        // Вывод данных в таблицы
        public static void OutputInfoInTables(DataGridView d_InputTable, DataGridView d_OutputTable, LayerNet[] l_LayersNet)
        {
            // Очистка таблиц
            d_InputTable.Rows.Clear();
            d_OutputTable.Rows.Clear();
            // Добавление имен в обе таблицы
            for (int i = 0; i < l_LayersNet[0].GetSetInputNodes.Length; i++)
            {
                d_InputTable.Rows.Add(l_LayersNet[0].GetSetInputNodes[i].GetLabel, "");
            }
            for (int i = 0; i < l_LayersNet[l_LayersNet.Length - 1].GetSetOutputNodes.Length; i++)
            {
                d_OutputTable.Rows.Add(l_LayersNet[l_LayersNet.Length - 1].GetSetOutputNodes[i].GetLabel, "");
            }
        }

        // Получение данных из таблицы
        public static double[] GetInfoFromTable(DataGridView d_InputTable)
        {
            // Получение входных данных с формы
            double[] d_InputData = new double[d_InputTable.Rows.Count + 1];
            for (int i = 0; i < d_InputTable.Rows.Count; i++)
            {
                d_InputData[i] = Convert.ToDouble(d_InputTable[1, i].Value);
            }
            d_InputData[d_InputData.Length - 1] = 1;

            return d_InputData;
        }

        // Вывод результатов
        public static void OutputInfoInTable(double[] d_OutputData, DataGridView d_OutputTable)
        {
            for (int i = 0; i < d_OutputData.Length; i++)
            {
                d_OutputTable[1, i].Value = d_OutputData[i];
            }
        }
    }
}
