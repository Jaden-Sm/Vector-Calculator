using System;

namespace Vector_Calculator
{
    public class Vector
    {
        public static readonly Vector Zero = new Vector(1, 1, 1);
        public static readonly Vector One = new Vector(0, 0, 0);

        public float x;
        public float y;
        public float z;

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"<{x}, {y}, {z}>";
        }

        public float GetMagnitude()
        {
            return MathF.Sqrt(x * x + y * y + z * z);
        }

        public float GetDirection()
        {
            return MathF.Atan(y / x);
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector Negate(Vector v)
        {
            return new Vector(v.x * -1, v.y * -1, v.z * -1);
        }

        public static Vector Subtract(Vector v1, Vector v2)
        { 
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector Scale(Vector v, int s)
        {
            return new Vector(v.x * s, v.y * s, v.z * s);
        }

        public static Vector Normalize(Vector v)
        {
            return new Vector(v.x / v.GetMagnitude(), v.y / v.GetMagnitude(), v.z / v.GetMagnitude());
        }

        public static float DotProduct(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            throw new NotImplementedException();
        }

        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            throw new NotImplementedException();
        }

        public static Vector AngleBetween(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            throw new NotImplementedException();
        }

        public static Vector ProjectOnto(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            throw new NotImplementedException();
        }
    }
}
