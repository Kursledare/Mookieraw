using GameEngine;

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
    }
}