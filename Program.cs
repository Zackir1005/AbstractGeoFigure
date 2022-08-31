using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeoFigure 
{
    abstract class GeoFigure 
    {
        private string Name;

        public string name 
        {
            get { return Name; }
            set { Name = value; }
        }
        public abstract decimal Square();
    }
    class Rectangle : GeoFigure
    {
        public Rectangle() 
        {
            name = "Rect001";
            Length = 2.3m;
            Heigth = 3m;
        }
        public override decimal Square() 
        {
            decimal _square = this.length * this.heigth;
            return _square;
        }
        private decimal Length;

        public decimal length 
        {
            get { return Length; }
            set { Length = value; }
        }
        private decimal Heigth;

        public decimal heigth 
        {
            get { return Heigth; }
            set { Heigth = value; }
        }

    }
    class Triangle : GeoFigure 
    {
        public Triangle() 
        {
            name = "Triang001";
            AB = 3;
            BC = 4;
            AC = 5;
        }
        private decimal AB;

        public decimal ab 
        {
            get { return AB; }
            set { AB = value; }
        }
        private decimal BC;

        public decimal bc
        {
            get { return BC; }
            set { BC = value; }
        }
        private decimal AC;

        public decimal ac 
        {
            get { return AC; }
            set { AC = value; }
        }

        public override decimal Square() 
        {
            decimal P = (AB + BC + AC) / 2;
            return (decimal)Math.Sqrt
                ((double)(P * (P - AB) * (P - BC) * (P - AC)));
        }
    }

    class mySquare : GeoFigure {
        public mySquare() 
        {
            name = "sq001";
            Length = 3.3m;
        }
        public override decimal Square() 
        {
            decimal _square = this.length * this.length;
            return _square;
        }
        private decimal Length;

        public decimal length 
        {
            get { return Length; }
            set { Length = value; }
        }
    }
    class Circle : GeoFigure {
        public Circle() {
            name = "circle";
            PI = 3.14m;
            R = 5m;
        }
        public override decimal Square() {
            decimal _square = pi * (r * r);
            return _square;
        }
        private decimal PI;

        public decimal pi {
            get { return PI; }
            set { PI = value; }
        }
        private decimal R;

        public decimal r {
            get { return R; }
            set { R = value; }
        }

    }
    class PerRectangle : GeoFigure { // Per - Периметр
        public PerRectangle() {
            name = "Rect002";
            Length = 2m;
            Heigth = 4m;
        }
        public override decimal Square() {

            decimal _square = 2 * (Length + Heigth);
            return _square;
        }
        private decimal Length;

        public decimal length {
            get { return Length; }
            set { Length = value; }
        }
        private decimal Heigth;

        public decimal heigth {
            get { return Heigth; }
            set { Heigth = value; }
        }

    }
    class PerTriangle : GeoFigure {
        public PerTriangle() {
            name = "Triang001";
            AB = 6;
            BC = 7;
            AC = 8;
        }
        private int AB;

        public int ab {
            get { return AB; }
            set { AB = value; }
        }
        private int BC;

        public int bc {
            get { return BC; }
            set { BC = value; }
        }
        private int AC;

        public int ac {
            get { return AC; }
            set { AC = value; }
        }

        public override decimal Square() {
            decimal Per = AB + BC + AC;
            return Per;
        }
    }

    class PermySquare : GeoFigure {
        public PermySquare() {
            name = "sq001";
            Length = 10m;
        }
        public override decimal Square() {
            decimal _square = 4 * Length;
            return _square;
        }
        private decimal Length;

        public decimal length {
            get { return Length; }
            set { Length = value; }
        }
    }
    class PerCircle : GeoFigure {
        public PerCircle() {
            name = "circle";
            PI = 3.14m;
            R = 4m;
        }
        public override decimal Square() {
            decimal _square = 2 * pi * r;
            return _square;
        }
        private decimal PI;

        public decimal pi {
            get { return PI; }
            set { PI = value; }
        }
        private decimal R;

        public decimal r {
            get { return R; }
            set { R = value; }
        }
    }

    class Program 
    {
        static void Main(string[] args) 
        {
            // Площадь
            Rectangle myRectangle = new Rectangle();
            myRectangle.name = "ПРЯМОУГОЛЬНИК";
            Console.WriteLine("Фигура {0} имеет площадь {1}", myRectangle.name, myRectangle.Square());
            Triangle myTriangle = new Triangle();
            myTriangle.name = "ТРEУГОЛЬНИК";
            Console.WriteLine("Фигура {0} имеет площадь {1}", myTriangle.name, myTriangle.Square());
            mySquare _square = new mySquare();
            _square.name = "КВАДРАТ";
            Console.WriteLine("Фигура {0} имеет площадь {1}", _square.name, _square.Square());
            Circle _circle = new Circle();
            _circle.name = "КРУГ";
            Console.WriteLine("Фигура {0} имеет площадь {1}", _circle.name, _circle.Square());
            Console.WriteLine();
            // Периметр
            PerRectangle myPerRectangle = new PerRectangle();
            myPerRectangle.name = "ПРЯМОУГОЛЬНИК";
            Console.WriteLine("Фигура {0} имеет периметр {1}", myPerRectangle.name, myPerRectangle.Square());
            PerTriangle myPerTriangle = new PerTriangle();
            myPerTriangle.name = "ТРEУГОЛЬНИК";
            Console.WriteLine("Фигура {0} имеет периметр {1}", myPerTriangle.name, myPerTriangle.Square());
            PermySquare _Persquare = new PermySquare();
            _Persquare.name = "КВАДРАТ";
            Console.WriteLine("Фигура {0} имеет периметр {1}", _Persquare.name, _Persquare.Square());
            PerCircle _Percircle = new PerCircle();
            _Percircle.name = "КРУГ";
            Console.WriteLine("Фигура {0} имеет периметр {1}", _Percircle.name, _Percircle.Square());
            Console.WriteLine();

            GeoFigure[] myArray = new GeoFigure[2];
            myArray[0] = myRectangle;
            myArray[1] = myTriangle;
        }
    }
}
