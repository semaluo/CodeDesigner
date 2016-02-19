using System;

namespace Netron.NetronLight
{
    public enum CanvasBackgroundTypes
    {

        FlatColor,
        Gradient,
        Image

    }
    public enum ShapeTypes
	{
		SimpleRectangle,
		SimpleEllipse,
		TextLabel,
		ClassShape,
        TextOnly,
        ImageShape,
        DecisionShape
	}
    public enum SelectionTypes
    {
        Inclusion,
        Partial
    }
    public enum SortByType
    {
        Method = 0,
        Property = 1
    }

    public enum SortDirection
    {
        Ascending = 0,
        Descending = 1
    }

    public enum TransformTypes
    { 
        NW,
        N,
        NE,
        E,
        SE,
        S,
        SW,
        W
    }
}
