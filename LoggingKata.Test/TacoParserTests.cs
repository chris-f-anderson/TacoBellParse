using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell")]
        [InlineData("34.035985, -84.683302, Taco Bell")]
        [InlineData("34.087508, -84.575512, Taco Bell")]
        [InlineData("90, 180, Taco Bell")]
        [InlineData("-90, -180, Taco Bell")]
        [InlineData("0, 0, Taco Bell")]      
        public void ShouldParse(string str)
        {
            //Arrange
            TacoParser tacoparser = new TacoParser();

            //Act
            ITrackable actual = tacoparser.Parse(str);

            //Assert
            Assert.NotNull(actual);
            
            
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData(" ", null)]
        [InlineData("Me", null)]


        public void ShouldFailParse(string str, ITrackable expected)
        {
            

            //Arrange
            TacoParser tacoParser = new TacoParser();

            //Act
            ITrackable actual = tacoParser.Parse(str);

            //Assert
            Assert.Equal(actual, expected);
        }
    }
}
