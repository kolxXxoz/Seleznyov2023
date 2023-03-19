namespace Structures.UnitTests
{
    public class ConsigmentTests
    {
        [Test]
        public void ConstructorTest()
        {
            var consigment = new Consigment(42, 79.9);
            Assert.That(consigment.Quantity, Is.EqualTo(42));
            Assert.That(consigment.Price, Is.EqualTo(79.9));
        }

        [TestCase(-30)]
        public void QuantitySet_NegativeValue_ArgumentException(int val)
        {
            var consigment = new Consigment();
            Assert.That(() => consigment.Quantity = val, Throws.ArgumentException);
        }

        [TestCase(-30.0)]
        public void PriceSet_NegativeValue_ArgumentException(double val)
        {
            var consigment = new Consigment();
            Assert.That(() => consigment.Price = val, Throws.ArgumentException);
        }

        [TestCase(42, 79.9, 3355.8)]
        [TestCase(0, 0.0, 0.0)]
        public void CostTest(int qty, double price, double result)
        {
            var consigment = new Consigment(qty, price);
            Assert.That(consigment.Cost, Is.EqualTo(result));
        }

        [TestCase(42, 79.9, "42 шт. по 79,90 руб.")]
        [TestCase(0, 0.0, "0 шт. по 0,00 руб.")]
        public void ToStringTest(int qty, double price, string result)
        {
            var consigment = new Consigment(qty, price);
            Assert.That(consigment.ToString(), Is.EqualTo(result));
        }

        [TestCase(30, 30, true)]
        [TestCase(30, 15, false)] 
        public void Equals_TwoConsigments_ExpectedResult(int qty1, int qty2, bool result) 
        { 
            var consigment1 = new Consigment(qty1, 0.0); 
            var consigment2 = new Consigment(qty2, 0.0); 
            Assert.That(consigment1.Equals(consigment2), Is.EqualTo(result)); 
        }

        [Test] 
        public void Equals_WrongArgument_ArgumentException() 
        { 
            var consigment = new Consigment(); 
            var smth = new object(); 
            Assert.That(() => consigment.Equals(smth), Throws.ArgumentException); 
        }

        [Test] 
        public static void GetHashCodeTest() 
        { 
            var x = new Consigment(45, 18.0); 
            var y = new Consigment(45, 18.0); 
            var z = new Consigment(18, 45.0); 
            Assert.That(x.Equals(y), Is.True); 
            Assert.That(x.Equals(z), Is.False); 
        }

        [TestCase(42, 79.9, 24, 79.9, 66, 79.9)]
        [TestCase(42, 79.9, 0, 79.9, 42, 79.9)]
        public void AdditionTest(int qty1, double price1, int qty2, double price2, int resultQty, double resultPrice)
        {
            var consigment1 = new Consigment(qty1, price1);
            var consigment2 = new Consigment(qty2, price2);
            var result = new Consigment(resultQty, resultPrice);
            Assert.That(consigment1 + consigment2, Is.EqualTo(result));
        }

        [TestCase(42, 79.9, 24, 99.9)]
        public void Addition_DifferentPrices_ArgumentException(int qty1, double price1, int qty2, double price2)
        {
            var consigment1 = new Consigment(qty1, price1);
            var consigment2 = new Consigment(qty2, price2);
            Assert.That(() => consigment1 + consigment2, Throws.ArgumentException);
        }

        [TestCase(42, 79.9, 24, 79.9, 18, 79.9)]
        [TestCase(42, 79.9, 0, 79.9, 42, 79.9)]
        public void SubstractionTest(int qty1, double price1, int qty2, double price2, int resultQty, double resultPrice)
        {
            var consigment1 = new Consigment(qty1, price1);
            var consigment2 = new Consigment(qty2, price2);
            var result = new Consigment(resultQty, resultPrice);
            Assert.That(consigment1 - consigment2, Is.EqualTo(result));
        }

        [TestCase(42, 79.9, 24, 99.9)]
        public void Substraction_DifferentPrices_ArgumentException(int qty1, double price1, int qty2, double price2)
        {
            var consigment1 = new Consigment(qty1, price1);
            var consigment2 = new Consigment(qty2, price2);
            Assert.That(() => consigment1 - consigment2, Throws.ArgumentException);
        }

        [TestCase(42, 79.9, 24, 79.9)]
        public void Substraction_BigSubstracted_ArgumentException(int qty1, double price1, int qty2, double price2)
        {
            var consigment1 = new Consigment(qty1, price1);
            var consigment2 = new Consigment(qty2, price2);
            Assert.That(() => consigment2 - consigment1, Throws.ArgumentException);
        }
    }
}