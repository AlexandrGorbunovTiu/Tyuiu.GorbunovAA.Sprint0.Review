using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GorbunovAA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.GorbunovAA.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "TaskReview";
            Console.WriteLine("*********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                       *");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("* Введите значение переменной Х                         *");
            var x1 = Console.ReadLine();
            var x = Convert.ToInt32(x1);

            Console.WriteLine("*********************************************************");
            Console.WriteLine("* Введите значение переменной Y                         *");
            var y1 = Console.ReadLine();
            var y = Convert.ToInt32(y1);

            Console.WriteLine("*********************************************************");
            Console.WriteLine("* Введите значение переменной Z                         *");
            var z1 = Console.ReadLine();
            var z = Convert.ToInt32(z1);

            var otvet = ds.Calc(x, y, z);

            Console.WriteLine("*********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                             *");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("( " + x + " + " + y + " + " + z + " ) * 5 = " + otvet);
            Console.ReadLine();
        }
    }
}
