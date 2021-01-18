using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
   public class Circle : ColoredFigure
    {
        public Circle(string color, double size) : base(color, size)
        {

        }

        public override string GerArea()
        {
            double area = Math.PI*(this.Size*this.Size);
            return $"{nameof(Circle)} area: {area}";
        }

        public override string GetName()
        {
            return nameof(Circle);
        }
    }
}
