using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme14Pr1
{
    /// <summary>
    /// Класс 
    /// </summary>
    class MyClass
    {
        /// <summary>
        /// Открытое статическое поле number
        /// </summary>
        public static int number;
        /// <summary>
        /// Открытое статическое поле value
        /// </summary>
        public static int value;
        /// <summary>
        /// Открытая поле a
        /// </summary>
        public const int a = 125;
        /// <summary>
        /// Мето вывода поля number
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"{number}\n{value}");
        }
        /// <summary>
        /// 1.Статический конструктор выполняется только 1 раз, независимо от кол-ва созданных объектов
        /// 2.Статический конструктор не имеет модификаторов доступа
        /// 3.В статическом конструкторе никогла не бывает параметров
        /// 4.Статический конструктор нельзя в программе вызвать вручную, он вызывается автоматически при создании объекта
        /// 5.В стат.к-ре нельзя использовать this
        /// </summary>
        static MyClass()
        {
            Console.WriteLine("Статический конструктор");
            number = 1;
        }
        public MyClass()
        {
            Console.WriteLine("");
            number = 2;
        }
    }

    
}
