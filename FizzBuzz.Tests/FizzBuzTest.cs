using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzExemploTDD.Tests
{
    [TestClass]
    public class FizzBuzTest
    {
        [TestMethod]
        public void RetornarNumeroUmParaNumeroUm()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var resultado = fizzBuzz.ObterNumeroFizzBuzz(1);

            // Assert
            Assert.AreEqual("1", resultado);
        }

        [TestMethod]
        public void RetornarNumeroDoisParaNumeroDois()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var resultado = fizzBuzz.ObterNumeroFizzBuzz(2);

            // Assert
            Assert.AreEqual("2", resultado);
        }

        [TestMethod]
        public void RetornarFizzParaNumeroTres()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var resultado = fizzBuzz.ObterNumeroFizzBuzz(3);

            // Assert
            Assert.AreEqual("Fizz", resultado);
        }

        [TestMethod]
        public void RetornarNumeroQuatroParaNumeroQuatro()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var resultado = fizzBuzz.ObterNumeroFizzBuzz(4);

            // Assert
            Assert.AreEqual("4", resultado);
        }

        [TestMethod]
        public void RetornarBuzzParaNumeroCinco()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var resultado = fizzBuzz.ObterNumeroFizzBuzz(5);

            // Assert
            Assert.AreEqual("Buzz", resultado);
        }

        [TestMethod]
        public void RetornarFizzParaNumeroSeis()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var resultado = fizzBuzz.ObterNumeroFizzBuzz(6);

            // Assert
            Assert.AreEqual("Fizz", resultado);
        }

        [TestMethod]
        public void RetornarFizzParaNumeroNove()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var resultado = fizzBuzz.ObterNumeroFizzBuzz(9);

            // Assert
            Assert.AreEqual("Fizz", resultado);
        }

        [TestMethod]
        public void RetornarBuzzParaNumeroDez()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var resultado = fizzBuzz.ObterNumeroFizzBuzz(10);

            // Assert
            Assert.AreEqual("Buzz", resultado);
        }

        [TestMethod]
        public void RetornarFizzBuzzParaNumeroQuinze()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var resultado = fizzBuzz.ObterNumeroFizzBuzz(15);

            // Assert
            Assert.AreEqual("FizzBuzz", resultado);
        }

        [TestMethod]
        public void RetornarFizzBuzzParaNumeroTrinta()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var resultado = fizzBuzz.ObterNumeroFizzBuzz(30);

            // Assert
            Assert.AreEqual("FizzBuzz", resultado);
        }
    }
}