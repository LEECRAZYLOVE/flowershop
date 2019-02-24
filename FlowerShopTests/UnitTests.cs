using NUnit.Framework;
using FlowerShop;
using NSubstitute;
using System.Collections.Generic;


namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            IClient C = Substitute.For<IClient>();
            IOrderDAO O = Substitute.For<IOrderDAO>();
            IFlowerDAO F = Substitute.For<IFlowerDAO>();
            Flower F1 = new Flower(F, "Rose", 45.99, 3);
            Flower F2 = new Flower(F, "Orchard", 38.99, 2);
            Flower F3 = new Flower(F, "R", 64.99, 1);

            //Act
            List<Flower> FList = new List<Flower> { F1 };//, F2, F3};
            Order Ord = new Order(O, C);
            Ord.Deliver();

            //Assert
            Assert.IsTrue(Ord.isDelivered = true);
        }
    }
}