using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            var vectorA = new Vector("A", -2, 2, 3);

            var vectorB = new Vector("B", -3, -1, 0);

            Console.WriteLine("Два вектора:");

            vectorA.DisplayInfo();

            vectorB.DisplayInfo();

            Console.WriteLine($"Длина {vectorA.VectorName} = {vectorA.VectorLength()}");

            Console.WriteLine($"Длина {vectorB.VectorName} = {vectorB.VectorLength()}");

            Console.WriteLine($"Скалярное произведение = {Vector.VectorsScalar(vectorA, vectorB)}");

            var vectorC = Vector.VectorsProduct(vectorA, vectorB, "C");

            Console.WriteLine($"Векторное произведение {vectorA.VectorName} и {vectorB.VectorName} => вектор {vectorC.VectorName} ");

            vectorC.DisplayInfo();

            Console.WriteLine($"Угол между {vectorA.VectorName} и {vectorB.VectorName} = {Vector.VectorsAngle(vectorA, vectorB)} ");

            var vectorD = Vector.VectorsSum(vectorA, vectorB, "D");

            Console.WriteLine($"Суммой {vectorA.VectorName} и {vectorB.VectorName} => вектор {vectorD.VectorName} ");

            vectorD.DisplayInfo();

            var vectorE = Vector.VectorsSubtraction(vectorA, vectorB, "E");

            Console.WriteLine($"Разность {vectorA.VectorName} и {vectorB.VectorName} => вектор {vectorE.VectorName} ");

            vectorE.DisplayInfo();
        }
    }
}
