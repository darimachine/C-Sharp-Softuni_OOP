using System;
using System.Collections.Generic;

namespace Shapes
{
    public interface IDrawable
    {
        void Draw();
        void DrawShape();
    }
    public class Circle : IDrawable
    {
        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public int Radius { get; set; }

        public void Draw()
        {
            for (int i = 0; i < this.Radius*2; i++)
            {
                for (int j = 0; j < this.Radius*2; j++)
                {
                    var distance = Math.Sqrt((this.Radius - i) * (this.Radius - i) + (this.Radius - j) * (this.Radius - j));
                    if (distance<this.Radius) 
                    {
                        Console.Write("**");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    
                }
                Console.WriteLine();
            }
        }

        public void DrawShape()
        {
            
        }

        public override string ToString()
        {
            return $"Circle radius is {this.Radius}";
        }
    }
    public class Rectangle : IDrawable
    {
        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width { get; set; }
        public int Height { get; set; }

        public void Draw()
        {
            for (int i = 0; i < this.Height; i++)
            {
                Console.WriteLine(new string('*', this.Width));

                
            }
        }

        public void DrawShape()
        {
            
        }

        public override string ToString()
        {
            return $"Rectangle width is {this.Width} and height is {this.Height}";
        }
    }
    public class Square : IDrawable
    {
        public Square(int side)
        {
            this.Side = side;
        }

        public int Side { get; }

        public void Draw()
        {
            for (int i = 0; i < this.Side; i++)
            {
                Console.WriteLine(new string('*',this.Side));

               
            }
        }

        public void DrawShape()
        {
            for (int i = 0; i < this.Side; i++)
            {
                Console.WriteLine("**" + new string(' ', this.Side) + "**");
            }
        }

        public override string ToString()
        {
            return $"Square side is {this.Side}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<IDrawable> shapes = new List<IDrawable>();
            shapes.Add(new Circle(7));
            shapes.Add(new Square(7));
            shapes.Add(new Rectangle(10,5));
            shapes.Add(new Square(9));
            shapes.Add(new Circle(9));
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
                shape.DrawShape();
                
            }
        }
    }
}
