﻿using System;
using System.Drawing;
using System.Windows.Forms;
using FlowDesigner.Tool;
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
    }
}