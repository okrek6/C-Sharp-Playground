using C_Sharp_Playground.Service;

namespace CSharpPlaygroundsTest
{
    public class WeatherForecastServiceTests
    {
        //methodUnderTest_Scenario_ExpectedOutput
        //GetWeather_With1Input_ExpectBalmyOutput
        [Fact]
        public void GetWeather_Null_Errors()
        {
            WeatherForecastService subject = new WeatherForecastService();

            Assert.Throws<ArgumentNullException>(() => subject.GetWeather(null));
        }
        [Theory]
        [InlineData("test1")]
        [InlineData("test2")]
        [InlineData("whatever")]
        public void GetWeather_ValidInput_ReturnsWarmSummary(string x)
        {
            var expected = C_Sharp_Playground.Models.Enums.WeatherSummary.Warm;

            WeatherForecastService subject = new WeatherForecastService();

            var result = subject.GetWeather(x);
            Assert.Equal(expected,result.First().Summary);
        }
    }
}