using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Fibonacci
{
    [TestFixture]
    public class ApplicationFibonacciTests
    {
        private IApplicationFibonacci _fibonacci;

        [SetUp]
        public void Setup()
        {
            _fibonacci = new ApplicationFibonacci();
        }

        [Test]
        public void Fibonacci_Input3_Return2()
        {
            //Arrange

            //Act
            long result = _fibonacci.SerieFibonacci(3);

            //Assert
            Assert.IsTrue(result == 2);
        }

        [Test]
        public void Fibonacci_Input6_Return8()
        {
            //Arrange

            //Act
            long result = _fibonacci.SerieFibonacci(6);

            //Assert
            Assert.IsTrue(result == 8);
            Assert.That(result, Is.EqualTo(8));
        }
    }
}
