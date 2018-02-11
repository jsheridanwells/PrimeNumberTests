using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
      private readonly PrimeService _primeService;
      public PrimeService_IsPrimeShould()
      {
        _primeService = new PrimeService();
      }

      [Test]
      public void ReturnFalseGivenValueOf1()
      {
        var result = _primeService.IsPrime(1);
        Assert.IsFalse(result, "1 should not be prime.");
      }

      [TestCase(-1)]
      [TestCase(0)]
      [TestCase(1)]
      public void ReturnFalseGivenValuesLessThan2(int value)
      {
          var result = _primeService.IsPrime(value);
          Assert.IsFalse(result, $"{value} should not be prime");
      }
      
      [TestCase(2)]
      [TestCase(3)]
      [TestCase(5)]
      public void ReturnTrueGivenPrimeNumbers(int value)
      {
        var result = _primeService.IsPrime(value);
        Assert.IsTrue(result, $"{value} should be prime");
      }

    }
}