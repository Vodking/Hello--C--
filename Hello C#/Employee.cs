using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_C_
{
    public class Employee
    {
        private string _position;
        public static decimal salary;
        public const string COMPANY_NAME = "Вадж";
        public readonly string departament;

        public Employee(string position, string departament)
        {
            _position = position;
            this.departament = departament;
        }
        public Employee(string position) : this(position, string.Empty) { } // string.Empty = ""

        public Employee() { }

        static Employee() 
        {

        }

        public static void Asd(Figure figure) { }

        public static void Increment(ref int a) // ref - ссылка, универсальная, in - входящая - переменная передаётся(ТОЛЬКО ЧТЕНИЕ), out - выходящая - переменная меняется там куда передали(ТОЛЬКО РЕДАКТИРОВАНИЕ)
        {
            a++;
        }

        public static void Sum(in int a, in int b, out int sum)
        {
            sum = a + b;
        }
        public static void Asd(int a, int b, params int[] values) // params - параметры, ввести как минимум один
        {

        }
    }
}
