using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    // Узел сети
    public struct NodeNet
    {
        // Имя узла
        private string s_Name;
        // Label узла
        private string s_Label;
        // Имена связанных узлов
        private string[] s_NamesLinkedNodes;
        // Имя оператора
        private string s_NameOperator;
        // Значение для оператора
        private double d_Value;

        public NodeNet(string s_Name,string s_Label, string[] s_NamesLinkedNodes, string s_NameOperator, double d_Value)
        {
            this.s_Name = s_Name;
            this.s_Label = s_Label;
            this.s_NamesLinkedNodes = s_NamesLinkedNodes;
            this.s_NameOperator = s_NameOperator;
            this.d_Value = d_Value;
        }

        public string GetName
        {
            get { return s_Name; }
        }
        public string GetLabel
        {
            get { return s_Label; }
        }
        public string[] GetNamesLinkedNodes
        {
            get { return s_NamesLinkedNodes; }
        }
        public string GetNameOperator
        {
            get { return s_NameOperator; }
        }
        public double GetValue
        {
            get { return d_Value; }
        }
    }



    // Слой
    public class LayerNet
    {
        // Имя слоя
        private string s_Name;
        // Входные узлы
        private NodeNet[] n_InputNodes;
        // Выходные узлы
        private NodeNet[] n_OutputNodes;
        // Матрица весов слоя
        double[,] d_MatrixWeights;
        // Входной вектор
        double[] d_InputVector;
        // Выходной вектор
        double[] d_OutputVector;


        public LayerNet(string s_Name)
        {
            this.s_Name = s_Name;
        }

        public string GetName
        {
            get { return s_Name; }
        }
        public NodeNet[] GetSetInputNodes
        {
            get { return n_InputNodes; }
            set { n_InputNodes = value; }
        }
        public NodeNet[] GetSetOutputNodes
        {
            get { return n_OutputNodes; }
            set { n_OutputNodes = value; }
        }
        public double[,] GetSetMatrixWeights
        {
            get { return d_MatrixWeights; }
            set { d_MatrixWeights = value; }
        }
        public double[] GetSetInputVector
        {
            get { return d_InputVector; }
            set { d_InputVector = value; }
        }
        public double[] GetSetOutputVector
        {
            get { return d_OutputVector; }
            set { d_OutputVector = value; }
        }
    }
}
