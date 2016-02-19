using System;
using System.Collections.Generic;
using System.Text;

namespace Netron.NetronLight
{
    public static class ShapeFactory
    {

        public static IShape GetShape(string shapeName)
        {
            if(string.IsNullOrEmpty(shapeName))
                return null;

            foreach(string shapeType in Enum.GetNames(typeof(ShapeTypes)))
            {
                if(shapeType.ToString().ToLower() ==shapeName.ToLower())
                {
                      return GetShape((ShapeTypes) Enum.Parse(typeof(ShapeTypes), shapeType));                    
                }
            }
            return null;
        }

        public static IShape GetShape(ShapeTypes shapeType)
        {
            switch(shapeType)
            {
                case ShapeTypes.SimpleRectangle:
                    return new SimpleRectangle();
                case ShapeTypes.SimpleEllipse:
                    return new SimpleEllipse();
                case ShapeTypes.TextLabel:
                    return new TextLabel();
                case ShapeTypes.ClassShape:
                    return new ClassShape();
                case ShapeTypes.TextOnly:
                    return new TextOnly();                    
                case ShapeTypes.ImageShape:
                    return new ImageShape();
                case ShapeTypes.DecisionShape:
                    break;
                default:
                    return null;
            }

            return null;
        }
  
    }
}
