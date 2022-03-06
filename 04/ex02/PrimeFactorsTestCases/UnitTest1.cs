using Xunit;

namespace PrimeFactorsTestCases;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // arrange
        int number = 4;
        string expectedResult = "2x2";

        // act
        string actualResult = new Prime("primes.json").PrimeFactors(number);

        // assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void Test2()
    {
        // arrange
        int number = 7;
        string expectedResult = "7";

        // act
        string actualResult = new Prime("primes.json").PrimeFactors(number);

        // assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void Test3()
    {
        // arrange
        int number = 30;
        string expectedResult = "2x3x5";

        // act
        string actualResult = new Prime("primes.json").PrimeFactors(number);

        // assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void Test4()
    {
        // arrange
        int number = 40;
        string expectedResult = "2x2x2x5";

        // act
        string actualResult = new Prime("primes.json").PrimeFactors(number);

        // assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void Test5()
    {
        // arrange
        int number = 50;
        string expectedResult = "2x5x5";

        // act
        string actualResult = new Prime("primes.json").PrimeFactors(number);

        // assert
        Assert.Equal(expectedResult, actualResult);
    }
}