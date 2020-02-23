using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ZedGraph;
using CW_Library;

namespace CourseWork_Client
{
    public partial class Client_Form : Form
    {
        Client client;
        public Client_Form()
        {
            InitializeComponent();
            client = new Client();
            try
            {
                client.Start(Convert.ToInt32(stepNumericUpDown.Value), Convert.ToInt32(halfperiodNumericUpDown.Value), Convert.ToInt32(degreeNumericUpDown.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Отсутствует соединение с сервером.");
            }
        }

        private void DrawGraph(GraphPane pane, List<Tuple<double, double>> tuples1, List<Tuple<double, double>> tuples2, int L, string name1, string name2, Color color1, Color color2, bool function)
        {
            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();

            for (double k = 0; k < tuples1.Count(); k++)
            {
                list1.Add(tuples1[(int)k].Item1, tuples1[(int)k].Item2); ;
            }

            for (double k = 0; k < tuples2.Count(); k++)
            {
                list2.Add(tuples2[(int)k].Item1, tuples2[(int)k].Item2); ;
            }


            pane.CurveList.Add(new LineItem(name1, list1, color1, SymbolType.None));
            pane.CurveList.Add(new LineItem(name2, list2, color2, SymbolType.None));



            pane.XAxis.MajorGrid.IsVisible = true;
            pane.XAxis.MajorGrid.Color = Color.Black;
            pane.XAxis.MajorGrid.DashOn = 5;
            pane.XAxis.MajorGrid.DashOff = 5;

            pane.YAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.Color = Color.Black;
            pane.YAxis.MajorGrid.DashOn = 5;
            pane.YAxis.MajorGrid.DashOff = 5;

            pane.YAxis.MajorGrid.IsZeroLine = false;

            if (function == true)
            {
                pane.XAxis.Scale.Max = L;
                pane.XAxis.Scale.Min = -L;

                pane.YAxis.Scale.Max = 20;
                pane.YAxis.Scale.Min = -20;
            }

            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Stop();
        }


        private void CreateFunction(object sender, EventArgs e)
        {
            {
                try
                {
                    MasterPane masterPane = zedGraph.MasterPane;
                    masterPane.PaneList.Clear();

                    //отправка запроса на сервер
                    client.Request(Convert.ToInt32(stepNumericUpDown.Value), Convert.ToInt32(halfperiodNumericUpDown.Value), Convert.ToInt32(degreeNumericUpDown.Value));

                    //данные для построения графа, полученные с сервера
                    GraphParameters graphParams = client.GetGraphParams;

                    //интегрирование
                    //GraphPane integrationGraph = new GraphPane();
                    //DrawGraph(integrationGraph, graphParams.GetIntegrationPoints1, Convert.ToInt32(periodNumericUpDown.Value), "Интегрирование ", Color.Red, false);
                    //DrawGraph(integrationGraph, graphParams.GetIntegrationPoints2, Convert.ToInt32(periodNumericUpDown.Value), "Интегрирование при 2*n", Color.Blue, false);
                    //masterPane.Add(integrationGraph);


                    //график функции
                    GraphPane Graph = new GraphPane();
                    DrawGraph(Graph, graphParams.GetFunctionPoints, graphParams.GetApproxyPoints, Convert.ToInt32(halfperiodNumericUpDown.Value), "График функции", "Апроксимация", Color.Black, Color.Red, true);
                    masterPane.Add(Graph);

                    //размещение графиков 
                    using (Graphics g = CreateGraphics())
                    {
                        masterPane.SetLayout(g, PaneLayout.SingleColumn);
                    }

                    zedGraph.AxisChange();
                    zedGraph.Invalidate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
            
    }
}