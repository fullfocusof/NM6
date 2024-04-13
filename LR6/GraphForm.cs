using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ZedGraph;

namespace LR6
{
    public partial class GraphForm : Form
    {
        private LagrangeForm parent;

        public GraphForm(int nodes, LagrangeForm parentLink)
        {
            parent = parentLink;
            InitializeComponent();

            ZedGraphControl zedGraphControl = new ZedGraphControl();
            GraphPane myPane = zedGraphControl.GraphPane;

            int width = ClientSize.Width;
            int height = ClientSize.Height;

            myPane.CurveList.Clear();
            myPane.GraphObjList.Clear();
            myPane.Title.Text = "График";
            myPane.XAxis.Title.Text = "X";
            myPane.YAxis.Title.Text = "Y";

            PointPairList pointPairList = new PointPairList();
            for (float x = -10; x <= 10; x += 0.1f)
            {
                float y = f(x);
                pointPairList.Add(x, y);
            }

            // Координаты узлов
            foreach (var node in parent.Data)
            {
                //pointPairList.Add(node.Item1, node.Item2);

                TextObj label = new TextObj($"({node.Item1}, {node.Item2})", node.Item1, node.Item2);
                label.FontSpec.Size = 6;
                label.FontSpec.FontColor = Color.Black;
                label.Location.AlignH = AlignH.Right;
                label.Location.AlignV = AlignV.Top;
                myPane.GraphObjList.Add(label);
            }
            TextObj labelTarget = new TextObj($"({parent.XTarget}, {parent.YTarget})", parent.XTarget, parent.YTarget);
            labelTarget.FontSpec.Size = 6;
            labelTarget.FontSpec.FontColor = Color.Black;
            labelTarget.Location.AlignH = AlignH.Right;
            labelTarget.Location.AlignV = AlignV.Top;
            myPane.GraphObjList.Add(labelTarget);


            // Красная вертикальная линия X* = 3.3
            LineObj line = new LineObj(Color.Red, parent.XTarget, 0, parent.XTarget, parent.YTarget);
            line.Line.Style = System.Drawing.Drawing2D.DashStyle.Dot;
            line.IsClippedToChartRect = true;
            myPane.GraphObjList.Add(line);

            // Легенда функции
            LineItem myCurve = myPane.AddCurve("y = 2.1sin(0.37x)", pointPairList, Color.Blue, SymbolType.Circle);
            myCurve.Symbol.Fill = new Fill(Color.Blue);
            myCurve.Line.IsVisible = true;

            // Легенда X*
            PointPairList markerList = new PointPairList();
            markerList.Add(parent.XTarget, 0);
            LineItem markerCurve = myPane.AddCurve("X* = 3.3", markerList, Color.Red, SymbolType.XCross);
            markerCurve.Symbol.Fill = new Fill(Color.Red);
            markerCurve.Line.IsVisible = false;

            zedGraphControl.Size = new Size(width, height);

            Controls.Add(zedGraphControl);
        }

        private float f(float x)
        {
            return (float)(2.1 * Math.Sin(0.37 * x));
        }
    }
}
