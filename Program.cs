using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 1
            double a = 16.80;
            double b = 12.40;
            double result = Math.Sqrt(a*b);
            Console.WriteLine($"Результат = {result}");
            //Ex 2
            a = 1.40;
            b = 5.50;
            double c = 0.60;
            double ac = a-c;
            double bc = b + c;
            result = ac + bc;
            Console.WriteLine($"AC = {ac} \nBC = {bc} \nAC + BC = {result}");
            //Ex 3
            double x1 = -6.20, x2 = 2.10,y1 = 5.20,y2 = 9.80;
            result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
            Console.WriteLine($"Результат = {result}");
            //Ex 4
            int dv = 41;
            int vd = dv%10 * 10 + dv/10;
            Console.WriteLine($"Результат = {vd}"); 
            //Ex 5
            int n = 10985;
            vd = n / 3600;
            Console.WriteLine($"Результат = {vd}");
            //Ex 6
            int k = 202;
            Console.WriteLine($"Номер дня недели: {k%7}");
        }
    }
}
