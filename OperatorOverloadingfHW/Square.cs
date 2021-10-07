using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingfHW
{
    class Square
    {
        private float side;

        public float Area => Side*Side;
        public float Side
        {
            get { return side; }
            set 
            { 
                side = (value>0)? value : 0; 
            }
        }

        public void Print()
        {
            Console.WriteLine($"Square side: {Side}m");
        }

        //constructors
        public Square(float side)
        {
            Side = side;
        }

        public Square() { }

        //Overloaded Operators
        public static Square operator ++(Square square)
        {
            square.Side += 0.1F;
            return square;
        }

        public static Square operator --(Square square)
        {
            square.Side -= 0.1F;
            return square;
        }

        public static Square operator +(Square left, Square right) => new Square(left.Side + right.Side);

        public static Square operator -(Square left, Square right) => new Square(left.Side - right.Side);

        public static Square operator *(Square square, float value) => new Square(square.Side * value);

        public static Square operator /(Square square, float value) => new Square(square.Side / value);

        public static bool operator >(Square left, Square right) => left.Area > right.Area;

        public static bool operator <(Square left, Square right) => left.Area < right.Area;

        public static bool operator >=(Square left, Square right) => left.Area >= right.Area;

        public static bool operator <=(Square left, Square right) => left.Area <= right.Area;

        public override bool Equals(object obj) => obj is Square square && Side == square.Side;

        public override int GetHashCode() => HashCode.Combine(side, Area, Side);

        public static bool operator ==(Square left, Square right) => left.Equals(right);

        public static bool operator !=(Square left, Square right) => !(left == right);

        public static bool operator true(Square square) => square.Area > 0;

        public static bool operator false(Square square) => square.Area == 0;

        public static implicit operator Rectangle(Square square) => square;

        public static implicit operator double(Square square) => square.Area;
    }
}
