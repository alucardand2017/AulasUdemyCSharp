using System;
using System.Collections.Generic;
using System.Text;
using ExercicioAreasFiguras.Entities.Enums;
namespace ExercicioAreasFiguras.Entities
{
    abstract class Shape
    {
        public Colors Color { get; set; }

        protected Shape(Colors color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}
