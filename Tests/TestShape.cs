using Shape;
using Xunit;

namespace Tests
{
    public class TestShape
    {
        [Fact]
        public void BoxVol()
        {
            var box = new Box(5);

            var result = box.Volume();

            Assert.Equal(125, result);
        }

        [Fact]
        public void BallVol()
        {
            var ball = new Ball(5);

            var result = ball.Volume();

            Assert.Equal(523.5987755982989, result);
        }

        [Fact]
        public void CylinderVol()
        {
            var cylinder = new Cylinder(2, 5);

            var result = cylinder.Volume();

            Assert.Equal(62.83185307179586, result);
        }

        [Fact]
        public void PyramidVol()
        {
            var pyramid = new Pyramid(5, 10);

            var result = pyramid.Volume();

            Assert.Equal(16.666666666666668, result);
        }
    }
}
