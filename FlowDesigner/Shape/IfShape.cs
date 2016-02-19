using System.Drawing;
using System.Drawing.Drawing2D;
using Netron.GraphLib;

namespace FlowDesigner
{
    public class IfShape : AbstractFlowChartShape
    {
        private Connector m_leftConnector;
        private Connector m_yesConnector;
        private Connector m_noConnector;

        protected override void InitEntity()
        {
            base.InitEntity();

            Rectangle = new RectangleF(0, 0, 0, 0);
            //add the connectors
            m_leftConnector = new Connector(this, "Left", true);
            m_leftConnector.ConnectorLocation = ConnectorLocation.West;
            Connectors.Add(m_leftConnector);

            m_yesConnector = new Connector(this, "Yes", true);
            m_yesConnector.ConnectorLocation = ConnectorLocation.Omni;
            Connectors.Add(m_yesConnector);

            m_noConnector = new Connector(this, "No", true);
            m_noConnector.ConnectorLocation = ConnectorLocation.Omni;
            Connectors.Add(m_noConnector);

        }


        public override PointF ConnectionPoint(Connector c)
        {
            if (c == m_leftConnector)
            {
                return new PointF(Rectangle.Left, Rectangle.Top + Rectangle.Height / 2);
            }

            if (c == m_yesConnector)
            {
                return new PointF(Rectangle.Right, Rectangle.Top);
            }

            if (c == m_noConnector)
            {
                return new PointF(Rectangle.Right, Rectangle.Bottom);
            }

            return new PointF(0, 0);
        }

        public override void Paint(Graphics g)
        {
            base.Paint(g);

            float t_width = Rectangle.Width * 8 / 10;
            float t_height = Rectangle.Height;

            PointF[] points = new PointF[6];
            points[0] = new PointF(Rectangle.Left, Rectangle.Top);
            points[1] = new PointF(Rectangle.Right, Rectangle.Top);
            points[2] = new PointF(Rectangle.Left + t_width, Rectangle.Top + Rectangle.Height/2);
            points[3] = new PointF(Rectangle.Right, Rectangle.Bottom);
            points[4] = new PointF(Rectangle.Left, Rectangle.Bottom);
            points[5] = new PointF(Rectangle.Left, Rectangle.Top);

            GraphicsPath path = new GraphicsPath();
            path.AddLines(points);
            
            
            //Draw shape line and shape background
            g.FillPath(new SolidBrush(ShapeColor), path);
            g.DrawPath(Pen, path);

            //Draw Text
            RectangleF t_textRect = new RectangleF(Rectangle.Location, new SizeF(t_width, t_height));
            t_textRect.Inflate(-1, -1);
            if (!string.IsNullOrEmpty(Text))
                g.DrawString(Text, this.Font, this.TextBrush, t_textRect);
        }
    }
}