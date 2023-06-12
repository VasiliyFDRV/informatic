
using System;
using NUnit.Framework;
using Task1_2023;

namespace Task1_2023.Vector2DUnitTest
{
    [TestFixture]
    public class Vector2DTests
    {
        private Vector2D CreateVector2D()
        {
            return new Vector2D(10, 15.5);
        }

        [Test]
        public void ConstructorTest()
        {
            var vector = CreateVector2D();

            Assert.That(vector.X, Is.EqualTo(10));
            Assert.That(vector.Y, Is.EqualTo(15.5));
            Assert.That(vector.Length, Is.EqualTo(Math.Sqrt(10 * 10 + 15.5 * 15.5)));
        }
        
        [Test]
        public void ToStringTest()
        {
            var vector = CreateVector2D();

            Assert.That(vector.ToString(), Is.EqualTo("(10,15.5)"));
        }

        [Test]
        public void EqualsTest()
        {
            var vector1 = CreateVector2D();
            var vector2 = new Vector2D(10, 15.5);
            var vector3 = new Vector2D(-5, 12);

            Assert.That(vector1.Equals(vector2));
            Assert.That(!vector1.Equals(vector3));
        }

        [Test]
        public void OperationsTest()
        {
            var vector1 = CreateVector2D();
            var vector2 = new Vector2D(10, 15.5);
            var vector3 = new Vector2D(-5, 12);

            Assert.That(vector1 == vector2);
            Assert.That(vector1 != vector3);
            Assert.That(vector1 + vector3 == new Vector2D(5, 27.5));
            Assert.That(vector1 - vector3 == new Vector2D(15, 3.5));
            Assert.That(vector1 * vector3 == 95);
            Assert.That(vector1 * 4 == new Vector2D(40, 62));
            Assert.That(4 * vector1 == new Vector2D(40, 62));
        }

    }
}
