using TS.TechnicalTest;

namespace TS.UnitTests;

[TestClass]
public class LongestSentanceTests
{
    [TestMethod]
    public void Q1_BasicNominalTest()
    {

        var input = "Forget CSs..Save time .xx";
        //var input = $"We test coders. Give us a try";
        var outcome = LongestSentanceAnswer.Solution(input);
        Assert.AreEqual(2, outcome);
    }
}
