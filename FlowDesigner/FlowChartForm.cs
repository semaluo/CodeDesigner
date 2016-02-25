using System;
using System.Drawing;
using System.Windows.Forms;
using FlowDesigner.Tool;
using FlowDesigner.Dialog;
using Netron.GraphLib;
using Netron.GraphLib.UI;
using WeifenLuo.WinFormsUI.Docking;

namespace FlowDesigner
{
    public partial class FlowChartForm : DockContent
    {
        private bool _mDrawShape = false;
        private Shape _mShape = null;

        private PointF m_startPoint ;

        public FlowChartForm()
        {
            InitializeComponent();
            graphControl.RestrictToCanvas = false;
            //graphControl.MouseDown += GraphControl_MouseDown;
            graphControl.MouseMove += GraphControl_MouseMove;
            //graphControl.MouseUp += GraphControl_MouseUp;
        }

        private void GraphControl_MouseMove(object sender, MouseEventArgs e)
        {
            this.labelX.Text = String.Format("X : {0}", e.Location.X);
            this.labelY.Text = String.Format("Y : {0}", e.Location.Y);
        }

        private void btn_sequence_Click(object sender, EventArgs e)
        {
            //graphControl.Locked = true;
            //_mDrawShape = true;
            SequenceShape shape = new SequenceShape();
            ShapeDrawTool.DrawShape(shape, graphControl);

            //this.graphControl.AddShape(shape);
        }

        private void btn_loop_Click(object sender, EventArgs e)
        {
            LoopShape shape = new LoopShape();
            ShapeDrawTool.DrawShape(shape, graphControl);
        }

        private void btn_if_Click(object sender, EventArgs e)
        {
            IfShape shape = new IfShape();
            ShapeDrawTool.DrawShape(shape, graphControl);
        }

        private void menu_open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    graphControl.Open(ofd.FileName);
                }
            }
        }

        private void menu_save_to_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    graphControl.SaveAs(sfd.FileName);
                }
            }
        }

        private void menu_layerManage_Click(object sender, EventArgs e)
        {
            LayersDialog dlg = new LayersDialog(graphControl);
            dlg.ShowDialog();
        }

        private void btn_switch_Click(object sender, EventArgs e)
        {
            BlockShape shape = new BlockShape(graphControl);
            ShapeDrawTool.DrawShape(shape, graphControl);
        }

        private void menu_goUpperLayer_Click(object sender, EventArgs e)
        {
            if (graphControl.Abstract.CurrentLayer != graphControl.Abstract.DefaultLayer)
            {
                foreach (Shape shape in graphControl.Shapes)
                {
                    if (shape is BlockShape)
                    {
                        GraphLayer layer = (shape as BlockShape).LinkedLayer;
                        if (layer != null && layer == graphControl.Abstract.CurrentLayer)
                        {
                            graphControl.Abstract.ActiveLayer(shape.Layer.Name);
                            return;
                        }
                    }
                }
            }
        }
    }
}
