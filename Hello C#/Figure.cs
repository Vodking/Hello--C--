
namespace Hello_C_
{
    public struct Figure
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

        public void Init(double x, double y)
        {
            _x = x;
            _y = y;
            Employee.Asd(this);
        }

        public double Sum { get { return _x + _y; } } //вычисляемое свойство
    }
}
