using System.Drawing;
using Netron.GraphLib;

namespace FlowDesigner
{
    public class LoopShape : AbstractFlowChartShape
    {
        private Connector m_leftConnector;
        private Connector m_rightConnector;

        protected override void InitEntity()
        {
            base.InitEntity();

            Rectangle = new RectangleF(0, 0, 0, 0);
            //add the connectors
            m_leftConnector = new Connector(this, "Left", true);
            m_leftConnector.ConnectorLocation = ConnectorLocation.West;
            Connectors.Add(m_leftConnector);

            m_rightConnector = new Connector(this, "Right", true);
            m_rightConnector.ConnectorLocation = ConnectorLocation.East;
            Connectors.Add(m_rightConnector);

        }


        public override PointF ConnectionPoint(Connector c)
        {
            if (c == m_leftConnector)
            {
                return new PointF(Rectangle.Left, Rectangle.Top + Rectangle.Height / 2);
            }

            if (c == m_rightConnector)
            {
                return new PointF(Rectangle.Right, Rectangle.Top + Rectangle.Height/2);
            }

            return new PointF(0, 0);
        }

        public override void Paint(Graphics g)
        {
            base.Paint(g);

            float t_width = Rectangle.Width*9/10;
            float t_height = Rectangle.Height;

            //Draw Rectangle
            g.FillRectangle(new SolidBrush(ShapeColor), Rectangle);
            g.DrawRectangle(Pen, System.Drawing.Rectangle.Round(Rectangle));

            //Draw line
            float t_x = Rectangle.Left + t_width;
            g.DrawLine(Pen, t_x, Rectangle.Top, t_x, Rectangle.Bottom);

            //Draw Text
            RectangleF t_textRect = new RectangleF(Rectangle.Location, new SizeF(t_width, t_height));
            t_textRect.Inflate(-1, -1);
            if (!string.IsNullOrEmpty(Text))
                g.DrawString(Text, this.Font, this.TextBrush, t_textRect);
        }
    }
}