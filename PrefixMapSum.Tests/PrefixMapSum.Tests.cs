using NUnit.Framework;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace PrefixMapSum.Tests
{
    public class Tests
    {
        private IMapSum PrefixMap { get; set; }
        private ServiceProvider ServiceProvider { get; set; }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            // Setup DI
            ServiceProvider = new ServiceCollection()
                .AddSingleton<IMapSum, PrefixMapSum>()
                .BuildServiceProvider();
        }

        [SetUp]
        public void Setup()
        {
            PrefixMap = ServiceProvider.GetService<IMapSum>();
            PrefixMap.Map.Clear();
        }

        [TestCase("columnar",3)]
        public void Insert_InsertingNewKey_SavesValueToMap(string key, int expectedValue)
        {
            // Arrange

            // Act
            PrefixMap.Insert(key, expectedValue);
            var insertedValue = PrefixMap.Map[key];

            // Assert
            Assert.That(insertedValue, Is.EqualTo(expectedValue));
        }

        [TestCase("columnar", 1, 3)]
        public void Insert_InsertingExistingKey_SavesNewValueToMap(string key, int currentValue, int newValue)
        {
            // Arrange


            // Act
            PrefixMap.Map.Add(new KeyValuePair<string, int>(key, currentValue));
            PrefixMap.Insert(key, newValue);
            var insertedValue = PrefixMap.Map[key];

            // Assert
            Assert.That(insertedValue, Is.EqualTo(newValue));
        }

        [Test]
        public void Sum_SumOfValuesWhoseKeyContainsString_IsCorrect()
        {
            // Arrange
            var expectedSum = 5;

            // Act
            PrefixMap.Map.Add(new KeyValuePair<string, int>("columnar", 3));
            PrefixMap.Map.Add(new KeyValuePair<string, int>("column", 2));

            var sum = PrefixMap.Sum("col");

            // Assert
            Assert.That(sum, Is.EqualTo(expectedSum));
        }
    }
}