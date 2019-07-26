using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything
        }

        [Theory]
        [InlineData("34.073638,-84.677017,Taco Bell Acwort")]
        [InlineData("34.035985, -84.683302, Taco Bell Acworth")]
        public void ShouldParse(string str)
        {
            // TODO: Complete Should Parse

            //Arrange
            TacoParser tacoParser = new TacoParser();

            // Act
            ITrackable actual = tacoParser.Parse(str);

            //Assert
            Assert.NotNull(actual);
            Assert.NotNull(actual.Location);
            Assert.NotNull(actual.Name);
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData("", null)]
        [InlineData("tacobell 23434", null)]
        [InlineData("aaabmbmmba", null)]
        public void ShouldFailParse(string str, ITrackable expected)
        {
            // TODO: Complete Should Fail Parse

            //Arrange
            TacoParser tacoParser = new TacoParser();

            // Act
            ITrackable actual = tacoParser.Parse(str);

            //Assert
            Assert.Equal(actual, expected);
        }
    }
}
