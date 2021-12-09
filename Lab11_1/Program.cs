using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача");
            Console.WriteLine("Задайте коэффициенты уравнения 0=kx+b");
            Console.WriteLine("Введите k");
            input(out double k);
            Console.WriteLine("Введите b");
            input(out double b);
            Equation equation = new Equation { k = k, b = b };
            equation.Root(b, k);

            Console.WriteLine("для завершения нажмитее любую клавишу");
            Console.ReadKey();
        }
        static void input(out double number)
        {
            try
            {
                number = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода данных! ВВедите значение заново");
                input(out number);
            }
        }
    }
    struct Equation
    {
        public double b;
        public double k;
        public void Root(double b, double k)
        {            
            try
            {
                if (k==0) throw new Exception();
                double x = -b / k;
                Console.WriteLine("Корень урравненияя равен {0} ", x);
            }
            catch (Exception)
            {
                Console.WriteLine("Урввнение не имеет вещественных корней");
            }
        }

    }
}
