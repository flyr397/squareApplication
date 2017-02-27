using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace squareApplication
{
    class Square
    {
        
        double sideA;
        double sideB;
        //string root = sideA * SideB;

        public void AcceptDetails()
        {
            sideA = 16.5;
            sideB = 16.5;
        }

        public double GetArea()
        {
            return sideA * sideB;
        }

        public void Display()
        {
            WriteLine("Side : {0}", sideA);
            WriteLine("Side : {0}", sideB);
            WriteLine("Area : {0}", GetArea());
            ReadKey();
        }
    }

    class ExecuteSquare
    {
        static void Main(string[] args)
        {
            Square s = new Square();

            s.AcceptDetails();
            s.Display();
            ReadLine();
        }
    }
}
