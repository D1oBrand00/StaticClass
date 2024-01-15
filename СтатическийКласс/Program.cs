using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme14Pr1
{
    /// <summary>
    /// Основной класс
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance1 = new MyClass();
            MyClass instance2 = new MyClass();
            //instance1.number = 10;
            //instance2.number = 20;
            MyClass.number = 10;
            MyClass.number = 20;
            MyClass.value = 30;
            instance1.Print();
            Console.WriteLine(MyClass.a);
            Console.Read();
        }
    }
}
