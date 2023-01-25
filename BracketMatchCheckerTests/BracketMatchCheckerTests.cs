using Xunit;
using BracketMatchChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketMatchChecker.Tests;
public class BracketMatchCheckerTests
{
    [Theory]
    [InlineData("{}", true)]
    [InlineData("", true)]
    [InlineData("{abc..xyz}", true)]
    [InlineData("}{", false)]
    [InlineData("{{}", false)]
    public void TestIsBracketMatched(string input, bool isExpectedMatched)
    {
        var res = BracketMatchChecker.Check(input);
        Assert.Equal(isExpectedMatched, res);
    }
}