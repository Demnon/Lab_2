using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDS.RDF;
using VDS.RDF.Parsing;
using VDS.RDF.Query;

namespace Lab_2
{
    // Работа с базой знаний
    public partial class KnowledgeBase : IDisposable
    {
        // Переменная для хранения БЗ
        Graph g_Graph;
        // Переменная для получения БЗ
        Notation3Parser n_Parser;
        // Строка подключения к БЗ
        string s_Path;
        // Данные нейросети
        LayerNet[] l_LayersNet;

        public KnowledgeBase(string s_Path)
        {
            g_Graph = new Graph();
            n_Parser = new Notation3Parser();
            this.s_Path = s_Path;
            // Получение БЗ из файла
            n_Parser.Load(g_Graph, s_Path);
            l_LayersNet = null;
        }

        public LayerNet[] GetNet
        {
            get { return l_LayersNet; }
        }
        
        // Получение нейросети из БЗ и заполнение матриц весов для каждого слоя
        public void GetDataNet()
        {
            // Получение слоев из БЗ
            l_LayersNet = GetLayersNet();
            // Просмотр слоев
            for (int i=0;i<l_LayersNet.Length;i++)
            {
                // Получаем входы первого слоя
                if (i == 0)
                {
                    l_LayersNet[i].GetSetInputNodes = GetInputNodesNet(l_LayersNet[i].GetName);
                }
                // Входы для остальных слоев
                else
                {
                    l_LayersNet[i].GetSetInputNodes = GetInputNodesOtherLayers(l_LayersNet[i - 1].GetSetOutputNodes);
                }

                // Выходы слоя
                l_LayersNet[i].GetSetOutputNodes = GetOutputNodes(l_LayersNet[i].GetName);

                // Получение матрицы весов для каждого слоя
                l_LayersNet[i].GetSetMatrixWeights = OperationsWithMatrix.GetMatrixWeight(l_LayersNet[i].GetSetInputNodes, l_LayersNet[i].GetSetOutputNodes);
            }
        }

        // Получение слоев нейросети в нужном порядке
        private LayerNet[] GetLayersNet() 
        {
            // Список со слоями
            List<LayerNet> l_LayersNet = new List<LayerNet>();
            // Получение первого слоя
            SparqlResultSet s_FirstLayer = (SparqlResultSet)g_Graph.ExecuteQuery(GetRequests("getfirstlayer"));
            l_LayersNet.Add(new LayerNet(GetName(s_FirstLayer[0]["layer"])));

            // Получение всех остальных слоев, пока не кончатся
            bool b_Test = true;
            while (b_Test)
            {
                SparqlResultSet s_NextLayer = (SparqlResultSet)g_Graph.ExecuteQuery(GetRequests("getnextlayer", l_LayersNet.Last().GetName));
                // Если следующий слой найден, то добавляем его, иначе выходим
                if (s_NextLayer.Count == 0)
                {
                    b_Test = false;
                }
                else
                {
                    l_LayersNet.Add(new LayerNet(GetName(s_NextLayer[0]["layer"])));
                }
            }

            // Лист слоев преобразовываем в массив и возвращаем
            return l_LayersNet.ToArray();
        }

        // Получение входов нейросети (входы первого слоя)
        private NodeNet[] GetInputNodesNet(string s_NameFirstLayer)
        {
            // Получение входных узлов из БЗ
            SparqlResultSet s_InputNodesNet = (SparqlResultSet)g_Graph.ExecuteQuery(GetRequests("getinputnodesnet",s_NameFirstLayer));
            // Массив узлов
            NodeNet[] n_Nodes = new NodeNet[s_InputNodesNet.Count];
            // Просмотр каждого узла и получение информации для него
            for (int i=0;i< s_InputNodesNet.Count;i++)
            {
                // Имя узла
                string s_NameNode = GetName(s_InputNodesNet[i]["input"]);
                // Label узла
                string s_Label = s_InputNodesNet[i]["label"].ToString();
                // Связанные узлы (для входов сети нет)
                string[] s_NamesLinkedNodes = null;
                // Имя оператора (для входов сети нет)
                string s_NameOperator = "";
                // Значение для оператора (для входов сети нет)
                double d_Value = 0;
                // Создание узла
                n_Nodes[i] = new NodeNet(s_NameNode, s_Label,s_NamesLinkedNodes, s_NameOperator, d_Value);
            }

            return n_Nodes;
        }

        // Получение входов остальных слоев, кроме первого
        private NodeNet[] GetInputNodesOtherLayers(NodeNet[] n_NodesPrevLayer)
        {
            // Переприсваивание - выходы предыдущего слоя являются входами текущего слоя
            NodeNet[] n_Nodes = n_NodesPrevLayer;
            return n_Nodes;
        }

        // Получение выходов любого слоя
        private NodeNet[] GetOutputNodes(string s_NameLayer)
        {
            // Получение выходных узлов из БЗ
            SparqlResultSet s_OutputNodes = (SparqlResultSet)g_Graph.ExecuteQuery(GetRequests("getoutputnodes", s_NameLayer));
            // Массив узлов
            NodeNet[] n_Nodes = new NodeNet[s_OutputNodes.Count];
            // Просмотр каждого узла и получение информации для него
            for (int i = 0; i < s_OutputNodes.Count; i++)
            {
                // Имя узла
                string s_NameNode = GetName(s_OutputNodes[i]["output"]);
                // Label узла
                string s_Label = s_OutputNodes[i]["label"].ToString();
                // Связанные узлы
                SparqlResultSet s_LinkedNodes = (SparqlResultSet)g_Graph.ExecuteQuery(GetRequests("getlinkednodes", s_NameNode));
                string[] s_NamesLinkedNodes = new string[s_LinkedNodes.Count];
                for (int j=0;j<s_LinkedNodes.Count;j++)
                {
                    s_NamesLinkedNodes[j] = GetName(s_LinkedNodes[j]["linked"]);
                }
                // Имя оператора
                SparqlResultSet s_Operator = (SparqlResultSet)g_Graph.ExecuteQuery(GetRequests("getoperator", s_NameNode));
                string s_NameOperator = GetName(s_Operator[0]["operator"]);
                // Значение для оператора, если оператор or или and, то значение не получать
                double d_Value = 0;
                if (s_NameOperator != "ins:or" && s_NameOperator != "ins:and")
                {
                    SparqlResultSet s_Value = (SparqlResultSet)g_Graph.ExecuteQuery(GetRequests("getvalue", s_NameNode));
                    d_Value = Convert.ToDouble(s_Value[0]["value"].ToString());
                }
                // Создание узла
                n_Nodes[i] = new NodeNet(s_NameNode,s_Label, s_NamesLinkedNodes, s_NameOperator, d_Value);
            }

            return n_Nodes;
        }


        // Получение имени из узла
        private string GetName(INode i_Node, string s_Prefix = "ins:")
        {
            string s_String = i_Node.ToString();
            string[] s_Mass = s_String.Split(':');
            // Отрежем слово stock
            string s_Name = "";
            for (int i=5;i< s_Mass[s_Mass.Length - 1].Length;i++)
            {
                s_Name += s_Mass[s_Mass.Length - 1][i];
            }
            return s_Prefix + s_Name;
        }


        // Освобождение ресурсов
        public void Dispose()
        {
            g_Graph.Dispose();
            n_Parser = null;
            l_LayersNet = null;
        }
    }
}
