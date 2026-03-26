using System.Collections.Generic;
using System.Text;

namespace Hello_C_
{
    internal class Program
    {
        enum DaysOfWeek : sbyte
        {
            Monday = 10,
            Tuesday, //11
            Wednesday, //12
            Thirsday, //13
            Friday = 22,
            Saturday,//23
            Sunday//24
        }
        static void Main(string[] args)
        {
            //string hello = "Hello, World";
            //Console.WriteLine(hello);
            /*
              Значимые типы(структуры)
             целочисл
            u = unsigned
            byte
            sbyte -128 +127
            short(Int16)
            ushort(UInt16)
            int(Int32)
            uint(UInt32)
            long(Int64)
            ulong(UInt64)
            
             дробные
            float (32 битный)
            double (64 битный)
            decimal (128 битный)

             символьный
            char

             логический
            bool

              Nullable-типы(ссылочный тип)
            string
            */

            float a = 3.4f;
            double b = 3.4d;
            decimal c = 3.4m;
            //тип название = значение
            var f = 4; //int

            //Dictionary<int, List<string>> dic = new Dictionary<int, List<string>>();
            //=
            // var dic = new Dictionary<int, List<string>>();

            /*
            Правила
            1. Классы, методы, свойства пишутся в PascalCase (Первая большая остальные тоже)
            2. Переменные в camelCase
            3. приватные поля _название (_ и camelCase)
            4. Порядок в классах: Приватные поля, публичные поля, статические поля, 
            конструкторы, статические методы, публичные методы, приватные методы.
            5. Один класс/структура = 1 файл.
            6. Интерфейсы называть IНазвание (I и PascalCase)
            7. В программе должно быть приглашение к вводу.
             
            */
            //Console.WriteLine(); //std::endl;
            //Console.Write(""); 
            //string g = Console.ReadLine();
            //char e = (char)Console.Read();
            /*
            структурные по значению. Дефолт = 0
            ссылочные по ссылке. Дефолт = null
            */

            //int h = 4;
            //Неявное
            //double hhh = b;
            //Явное
            //double hh = (double)h;
            //int cc = Convert.ToInt32(Console.ReadLine());
            //int ccc = int.Parse(Console.ReadLine());

            // ! || &&
            //& | - сокращённые
            // = *= /=
            // |= &= побитовые
            //

            //массив
            //int[] aa = new int[12];
            //int[] arr = {1,2,3,4,5,6}; //[6]
            //int[,] arrr = new int[2, 3]; //двумерный 2 строки 3 столбца
            //arrr[1, 1] = 1;
            //int[][] ffffff = new int[2][]; //зубчатый
            //ffffff[0] = new int[5];
            //ffffff[1] = new int[10];
            //ffffff[0][3] = 5;

            //StringBuilder sb = new StringBuilder();
        }
    }
}
