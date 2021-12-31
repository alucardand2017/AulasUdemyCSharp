using System;
using System.Collections.Generic;
using System.Text;
using ExercicioAreasFiguras.Entities.Enums;
namespace ExercicioAreasFiguras.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius, Colors color) : base(color)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
