using System;
using System.Collections.Generic;
using System.Linq;
using Dices;
using Dices.Interfaces;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    internal class DieTests
    {
        [Test]
        public void CanCreateDie()
        {
            Assert.DoesNotThrow(() =>
            {
                var listOfDices = new List<IDice>
                {
                    new D3(),
                    new D6(),
                    new D8(),
                    new D10(),
                    new D12(),
                    new D20(),
                    new D100()
                };
            });
        }

        [Test]
        public void DieRollDistribution()
        {
            const int numberOfTestRolls = 100000;
            var results = new int[10];
            var d10 = new D10();
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