namespace BracketMatchChecker.Tests;
public class BracketMatchCheckerTests
{
    [Theory]
    [InlineData("{}", true)]
    [InlineData("", true)]
    [InlineData("{abc..xyz}", true)]
    [InlineData("}{", false)]
    [InlineData("{{}", false)]
    public void TestCheck(string input, bool isExpectedMatched)
    {
        var res = BracketMatchChecker.Check(input);
        Assert.Equal(isExpectedMatched, res);
    }
}