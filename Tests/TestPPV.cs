using PointandPolygon;
using Xunit;

namespace Tests
{
    public class TestPPV
    {
        [Fact]
        public void TrianglePer()
        {
            var a = new Point("A", 3, 1);

            var b = new Point("B", 2, 2);

            var c = new Point("C", 1, 3);

            var polygon = new Polygon(a, b, c);

            var result = polygon.Perimeter();

            Assert.Equal(4,result);
        }

        [Fact]
        public void QuadranglePer()
        {
            var a = new Point("A", 4, 1);

            var b = new Point("B", 3, 2);

            var c = new Point("C", 2, 3);

            var d = new Point("D", 1, 4);

            var polygon = new Polygon(a, b, c, d);

            var result = polygon.Perimeter();

            Assert.Equal(7, result);
        }

        [Fact]
        public void PentagonPer()
        {
            var a = new Point("A", 5, 1);

            var b = new Point("B", 4, 2);

            var c = new Point("C", 3, 3);

            var d = new Point("D", 2, 4);

            var e = new Point("E", 1, 5);

            var polygon = new Polygon(a, b, c, d, e);

            var result = polygon.Perimeter();

            Assert.Equal(9, result);
        }

        [Fact]
        public void VectorLength()
        {
            var vector = new Vector("a", 1, 2, 3);

            var result = vector.VectorLength();

            Assert.Equal(3.7416573867739413, result);
        }

        [Fact]
        public void VectorsScalar()
        {
            var vectorA = new Vector("a", 1, 2, 3);

            var vectorB = new Vector("b", 3, 2, 1);

            var result = Vector.VectorsScalar(vectorA, vectorB);

            Assert.Equal(10, result);
        }

        [Fact]
        public void VectorsProduct()
        {
            var vectorA = new Vector("a", 3, 2, -2);

            var vectorB = new Vector("b", -1, 1, 3);

            var vectorC = Vector.VectorsProduct(vectorA, vectorB, "C");

            Assert.Equal(8, vectorC.X);

            Assert.Equal(-7, vectorC.Y);

            Assert.Equal(5, vectorC.Z);
        }

        [Fact]
        public void VectorsSum()
        {
            var vectorA = new Vector("a", -1, 2, 3);

            var vectorB = new Vector("b", -3, 0, 3);

            var vectorD = Vector.VectorsSum(vectorA, vectorB, "D");

            Assert.Equal(-4, vectorD.X);

            Assert.Equal(2, vectorD.Y);

            Assert.Equal(6, vectorD.Z);
        }

        [Fact]
        public void VectorsSubtraction()
        {
            var vectorA = new Vector("a", -1, 2, 3);

            var vectorB = new Vector("b", -3, 0, 3);

            var vectorD = Vector.VectorsSubtraction(vectorA, vectorB, "D");

            Assert.Equal(2, vectorD.X);

            Assert.Equal(2, vectorD.Y);

            Assert.Equal(0, vectorD.Z);
        }
    }
}
