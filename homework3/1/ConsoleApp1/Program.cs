using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface Shape
    {
        bool IShape();
        double Area();
    }
    class Rectangle : Shape
    {
      private  double  Length;
      private double Width;
      public double width { get => Width; }
        public double length { get => Length; }
      private static double Angle = 90.0;
        public Rectangle(double a, double b)
        {
            this.Width = a; this.Length = b;
            this.Draw();
        }
        public bool IShape()
        {
            if (Length < Width)
                return false;
            else if (Length < 0 && Width < 0)
            {
                return false;
            }
            else
                return true;

        }
        public double Area()
        {
            return Length * Width;
        }
        public void Draw()
        {
            if (this.IShape())
            {
                Console.Write("Rectangle" + " ");
                Console.WriteLine("area=" + this.Area());
            }
        }

    }
    class Square : Shape
    {
        private double edge;
        private static double Angle=90.0;
        public Square(double a)
        {
            this.edge = a;
            this.Draw();
        }
        public bool IShape()
        {
            if (edge < 0)
                return false;
            else
                return true;
        }
        public double Area()
        {
            return this.edge *this.edge;
        }
        public void Draw()
        {
            if (this.IShape())
            {
                Console.Write("Square" + " ");
                Console.WriteLine("area=" + this.Area());
            }
        }
    }
    class Triangle : Shape
    {
        double[] Edge = new double[3];
        double[] Angle = new double[3];
        //边1对应不是围成角1的那条边
        public Triangle(double a, double b, double c)
        {
            this.Edge[1] = a; this.Edge[2] = b; this.Edge[3] = c;
          //  this.Angle[1] = a1; this.Angle[2] = b1; this.Edge[3] = c1;
            this.Draw();
        }
        public bool IShape()
        {
           // double c = Edge[1] / Angle[1];
           // double Add = +Angle[i];
        
            
                 if (this.Edge[1] + this.Edge[2]> this.Edge[3] && this.Edge[1] + this.Edge[3] > this.Edge[2] && this.Edge[3] + this.Edge[2] > this.Edge[1])
                {
                    return true;
                }

                /*       else if (Angle[i] < 0)

                            return false;

                      else if (Edge[1] / Angle[1] != c) //正弦定理

                          return false;


                       else if (i == 3)
                        {
                            if (Add != 180.0)

                                return false;


                        }
                        */

                else
                    return false;

            
        }
        public double Area()
        {
            double p = (Edge[1] + Edge[2] + Edge[3]) / 2;
            return Math.Sqrt(p * (p - Edge[1]) * (p - Edge[2]) * (p - Edge[3]));
        }
        public void Draw()
        {
            if (this.IShape())
            {
                Console.Write("Triangle" + " ");
                Console.WriteLine("area=" + this.Area());
            }
        }
    }
        class Factory
        {
            private static readonly Random R = new Random();
            public static Object GetShape(int shapeType)
            {
                switch (shapeType)
                {
                    case 1:
                        return new Rectangle(10 * R.NextDouble(), 10 * R.NextDouble());
                    case 2:
                        return new Square(10 * R.NextDouble());
                    case 3:
                        return new Triangle(10 * R.NextDouble(), 10 * R.NextDouble(), 10 * R.NextDouble());
                    default:
                        throw new ArgumentException(message: "can't do it");
                }
            }
        }
    
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            Object[] shapes = new Object[10];
            for (int i = 0; i < 10; i++)
            {
                shapes[i] = Factory.GetShape(rd.Next(1, 3));
            }
        }
    }
}
