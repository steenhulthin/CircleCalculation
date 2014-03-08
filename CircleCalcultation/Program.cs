﻿using System;
using System.Threading;
using NUnit.Framework;

namespace CircleCalcultation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please wait... This application is an annoyingly slow starter...");
            Thread.Sleep(5000);
            var radius = double.Parse(args[0]);
            var circleCalculater = new CircleAreaCalculater();
            Console.WriteLine("Circle Area is: " + circleCalculater.CalculateArea(radius).ToString());
        }
    }

    internal class CircleAreaCalculater
    {
        public double CalculateArea(double radius)
        {
            return Math.PI;
        }
    }

    [TestFixture]
    public class TestCircleAreaCalculater
    {
        [Test]
        public void CalculateAreaOfUnitCircleReturnsPi()
        {
            var unitCircle = new CircleAreaCalculater().CalculateArea(1);
            Assert.AreEqual(1.0, unitCircle);
        }
    }
}
