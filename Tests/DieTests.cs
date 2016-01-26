using System;
using System.Linq;
using Dices;

namespace Tests
{
    [TestFixture]
    internal class DieTests
    {
        

        [Test]
        public void DieRollDistribution()
        {
            const int numberOfTestRolls = 100000;
            var results = new int[8];
            var d10 = new Dice(8);
            for (var i = 0; i < numberOfTestRolls; i++)
            {
                results[d10.Roll() - 1]++;
            }
            var counter = 1;
            foreach (var result in results)
            {
                Console.WriteLine($"{counter++}: {result}");
            }
            Assert.That(results.Max() - results.Min(), Is.LessThan(numberOfTestRolls*0.02));
        }
    }
}