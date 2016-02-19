using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Netron.GraphLib;
using Netron.GraphLib.Interfaces;
using Netron.GraphLib.UI;

namespace FlowDesigner
{

    public class SequenceShape : AbstractFlowChartShape
    {
        private Connector m_leftConnector;

        protected override void InitEntity()
        {
            base.InitEntity();

            Rectangle = new RectangleF(0, 0, 0, 0);
            //add the connectors
            m_leftConnector = new Connector(this, "Left", true);
            m_leftConnector.ConnectorLocation = ConnectorLocation.West;
            Connectors.Add(m_leftConnector);
        }


        public override PointF ConnectionPoint(Connector c)
        {
            if (c == m_leftConnector)
            {
                return new PointF(Rectangle.Left,Rectangle.Top + Rectangle.Height / 2 );
            }

            return new PointF(0,0);
        }

        public override void Paint(Graphics g)
        {
            base.Paint(g);
            g.FillRectangle(new SolidBrush(ShapeColor), Rectangle);
            g.DrawRectangle(Pen, System.Drawing.Rectangle.Round(Rectangle));

            if (!string.IsNullOrEmpty(Text))
                g.DrawString(Text,this.Font, this.TextBrush, System.Drawing.RectangleF.Inflate(Rectangle,0,-2));
        }


    }
}
