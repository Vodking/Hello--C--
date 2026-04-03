using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__strart
{
    internal class Figure
    {
        private double _x, _y;

        public double X // сеттер геттер для x
        {
            get { return _x; }
            set { _x = value; }
        }

        public double Y { get; set; } // автосвойство
        public Figure(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public Figure()
        {
            _x = 0;
            _y = 0;
        }

        public void Init(double x, double y)
        {
            _x = x;
            _y = y;
            Employee.Asd(this);
        }

        public double Sum { get { return _x + _y; } } //вычисляемое свойство
    }
}
