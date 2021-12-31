using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioAreasFiguras.Entities;
using ExercicioAreasFiguras.Entities.Enums;
namespace ExercicioAreasFiguras

{
    class Program
    {
        static void Main(string[] args)
        {
            

            var objetos = new List<Shape>();
            Console.Write("Enter the number os Shapes: ");
            int nShapes = int.Parse(Console.ReadLine());
            for (int i = 0; i < nShapes; i++)
            {
                Console.WriteLine($"Shape #{i + 1} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char tShape = char.Parse(Console.ReadLine().ToLower());
                try
                {
                    if (tShape == 'c')
                    {
                        Console.Write("Color (RED/BLUE/BLACK): ");
                        Colors colorTemp = Enum.Parse<Colors>(Console.ReadLine().ToUpper());
                        
                        Console.Write("Radius: ");
                        double radiusTemp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        
                        objetos.Add(new Circle(radiusTemp, colorTemp));
                    }
                    else if (tShape == 'r')
                    {
                        Console.Write("Color (RED/BLUE/BLACK): ");
                        Colors colorTemp = Enum.Parse<Colors>(Console.ReadLine().ToUpper());
                        
                        Console.Write("Width: ");
                        double widthTemp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        
                        Console.Write("Height: ");
                        double heightTemp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        
                        objetos.Add(new Rectangle(widthTemp, heightTemp, colorTemp));
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida!Repita a operação novamente!");
                        i--;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro de entrada de dados! {ex.Message}" );
                }
            }
            Console.WriteLine("SHAPES AREAS:");
            foreach( var area in objetos)
            {
                Console.WriteLine(area.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
