using System;

namespace OperatorOverloadingfHW
{
    class Rectangle
    {
        private static float minSide = 0.1F;
        private float length;
        private float width;

        //properties
        public float Length
        {
            get { return length; }
            set
            {
                length = (value > minSide) ? value : minSide;
            }
        }

        public float Width
        {
            get { return width; }
            set
            {
                width = (value > minSide) ? value : minSide;
            }
        }

        public float Area => Length * Width;

        ////methods
        public void Print()
        {
            Console.WriteLine($"Rectangle width: {Width}m, length: {Length}m");
        }

        //constructors
        public Rectangle(float width, float length)
        {
            Width = width;
            Length = length;
        }

        public Rectangle(){}

        //Overloaded Operators
        public static Rectangle operator ++(Rectangle rectangle)
        {
            rectangle.Length += 0.1F;
            rectangle.Width += 0.1F;
            return rectangle;
        }

        public static Rectangle operator --(Rectangle rectangle)
        {
            rectangle.Length -= 0.1F;
            rectangle.Width -= 0.1F;
            return rectangle;
        }

        public static Rectangle operator +(Rectangle left, Rectangle right)=> new Rectangle(left.Width + right.Width, left.Length + right.Length);

        public static Rectangle operator -(Rectangle left, Rectangle right) => new Rectangle(left.Width - right.Width, left.Length - right.Length);

        public static Rectangle operator *(Rectangle rectangle, float value) => new Rectangle(rectangle.Width * value, rectangle.Length * value);

        public static Rectangle operator /(Rectangle rectangle, float value) => new Rectangle(rectangle.Width / value, rectangle.Length / value);

        public static bool operator >(Rectangle left, Rectangle right) => left.Area > right.Area;

        public static bool operator <(Rectangle left, Rectangle right) => left.Area < right.Area;

        public static bool operator >=(Rectangle left, Rectangle right) => left.Area >= right.Area;

        public static bool operator <=(Rectangle left, Rectangle right) => left.Area <= right.Area;

        public override bool Equals(object obj) => obj is Rectangle rectangle && width == rectangle.width && length == rectangle.length;

        public override int GetHashCode() => HashCode.Combine(width);

        public static bool operator ==(Rectangle left, Rectangle right) => left.Equals(right);

        public static bool operator !=(Rectangle left, Rectangle right) => !(left == right);

        public static bool operator true(Rectangle rectangle) => rectangle.Area > 0;

        public static bool operator false(Rectangle rectangle) => rectangle.Area == 0;

        public static explicit operator Square(Rectangle rectangle) => (Square)rectangle;

        public static explicit operator double(Rectangle rectangle) => rectangle.Area;
    }
}
