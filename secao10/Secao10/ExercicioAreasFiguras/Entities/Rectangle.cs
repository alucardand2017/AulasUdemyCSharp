using System;
using System.Collections.Generic;
using System.Text;
using ExercicioAreasFiguras.Entities.Enums;
namespace ExercicioAreasFiguras.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height, Colors color) : base(color)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
