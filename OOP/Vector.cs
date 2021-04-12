using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointandPolygon
{
    public class Vector
    {
        public string VectorName;
        public double X;
        public double Y;
        public double Z;
        public Vector(string name, double x, double y, double z)
        {
            VectorName = name;
            X = x;
            Y = y;
            Z = z;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"{VectorName} ({X},{Y},{Z})");
        }
        public double VectorLength()
        {
            {
                double result = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
                return result;
            }
        }
        public static double VectorsScalar(Vector v1, Vector v2)
        {
            {
                double result = (v1.X * v2.X) + (v1.Y * v2.Y) + (v1.Z * v2.Z);
                return result;
            }
        }
        public static Vector VectorsProduct(Vector v1, Vector v2, string resultVectorName)
        {
            {
                var ProductX = (v1.Y * v2.Z) - (v1.Z * v2.Y);
                var ProductY = (v1.Z * v2.X) - (v1.X * v2.Z);
                var ProductZ = (v1.X * v2.Y) - (v1.Y * v2.X);
                var result = new Vector(resultVectorName, ProductX, ProductY, ProductZ);
                return result;
            }
        }
        public static double VectorsAngle(Vector v1, Vector v2)
        {
            {
                var result = VectorsScalar(v1, v2) / (Math.Abs(v1.VectorLength()) * Math.Abs(v2.VectorLength()));
                return result;
            }
        }
        public static Vector VectorsSum(Vector v1, Vector v2, string resultVectorName)
        {
            {
                var ProductX = (v1.X + v2.X);
                var ProductY = (v1.Y + v2.Y);
                var ProductZ = (v1.Z + v2.Z);
                var result = new Vector(resultVectorName, ProductX, ProductY, ProductZ);
                return result;
            }
        }
        public static Vector VectorsSubtraction(Vector v1, Vector v2, string resultVectorName)
        {
            {
                var ProductX = (v1.X - v2.X);
                var ProductY = (v1.Y - v2.Y);
                var ProductZ = (v1.Z - v2.Z);
                var result = new Vector(resultVectorName, ProductX, ProductY, ProductZ);
                return result;
            }
        }
    }
}
