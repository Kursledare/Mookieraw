using GameEngine;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Vector2Test
    {
        [Test]
        public void DistanceCheckIsCorrect()
        {
            var v1 = new Vector2(1, 1);
            var v2 = new Vector2(2, 2);
            var distance = Vector2.Distance(v1, v2);
            Assert.That(distance, Is.EqualTo(1.41421354f));
        }

        [Test]
        public void NormalizeIsCorrect()
        {
            var v1 = new Vector2(1,1);
            var v2 = new Vector2(1,10);
            var v3 = new Vector2(10,1);
            var normal1 = v1.Normalize(v2);
            var normal2 = v1.Normalize(v3);
            Assert.That(normal1.X,Is.EqualTo(0));
            Assert.That(normal1.Y, Is.EqualTo(1));
            Assert.That(normal2.X, Is.EqualTo(1));
            Assert.That(normal2.Y, Is.EqualTo(0));

        }
    }
}