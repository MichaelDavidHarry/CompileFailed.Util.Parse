using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompileFailed.Utility.ParseTests
{
    [TestFixture]
    public class ParseTest
    {
        [Test]
        public void ParseStringShouldReturnParsedValue()
        {
            var expected = new DateTime(2017, 12, 25);
            var actual = Parse.ParseString<DateTime>("12-25-17");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ParseStringShouldThrowFormatExceptionIfValueInvalid()
        {
            Assert.Throws<FormatException>(() => Parse.ParseString<Decimal>("This is not a decimal."));
        }

        [Test]
        public void ParseStringNullableShouldNotBeNullIfValueValid()
        {
            var actual = Parse.ParseStringNullable<Decimal>("3.14159");
            Assert.NotNull(actual);
        }

        [Test]
        public void ParseStringNullableShouldReturnNullIfValueInvalid()
        {
            var actual = Parse.ParseStringNullable<Guid>("This is not a guid.");
            Assert.IsNull(actual);
        }
    }
}
