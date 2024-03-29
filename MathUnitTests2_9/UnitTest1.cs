﻿using System;
using NUnit.Framework;
using Parameterized_Tests2_9.Fundamentals;
using Math = Parameterized_Tests2_9.Fundamentals.Math;

namespace MathUnitTests2_9
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {


            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 1, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {


            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

    } 
}
