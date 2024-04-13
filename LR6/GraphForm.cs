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

            foreach (var node in parent.Data)
            {
                pointPairList.Add(node.Item1, node.Item2);

                TextObj label = new TextObj($"({node.Item1}, {node.Item2})", node.Item1, node.Item2);
                label.FontSpec.Size = 6;
                label.FontSpec.FontColor = Color.Black;
                label.Location.AlignH = AlignH.Right;
                label.Location.AlignV = AlignV.Top;
                myPane.GraphObjList.Add(label);
            }

            LineObj line = new LineObj(Color.Red, parent.XTarget, 0, parent.XTarget, parent.YTarget);
            line.Line.Style = System.Drawing.Drawing2D.DashStyle.Dot;
            line.IsClippedToChartRect = true;
            myPane.GraphObjList.Add(line);

            LineItem myCurve = myPane.AddCurve("Узлы", pointPairList, Color.Blue, SymbolType.Circle);
            myCurve.Symbol.Fill = new Fill(Color.Blue);
            myCurve.Line.IsVisible = true;

            PointPairList markerList = new PointPairList();
            markerList.Add(parent.XTarget, 0);

            LineItem markerCurve = myPane.AddCurve("X*", markerList, Color.Red, SymbolType.XCross);
            markerCurve.Symbol.Fill = new Fill(Color.Red);
            markerCurve.Line.IsVisible = false;

            zedGraphControl.Size = new Size(width, height);

            Controls.Add(zedGraphControl);
        }
    }
}
