using System;

namespace Course5 {
    
    public class Program {

        static void Main(string[] args) {

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = 10 / 8;

            Console.WriteLine("Resultado de N1: " + n1);
            Console.WriteLine("Resultado de N2: " + n2);
            Console.WriteLine("Resultado de N3: " + n3);
            Console.WriteLine("Resultado de N4: " + n4);

            Console.WriteLine("----------------------------------------------------");

            double a = 1.0, b = -3.0, c = -4.0;

            //Math.Pow serve para calcular a potenciação
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }

    }

}