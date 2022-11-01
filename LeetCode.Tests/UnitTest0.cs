using System.Diagnostics;

namespace LeetCode.Tests;

public class UnitTest0 : UnitTest<Solution0>
{
    [Test]
    public void SpeedTest()
    {
        var sw = new Stopwatch();
        sw.Start();
        /*for(var time = 0; time<1000000; time++)
        {
            
        }*/
        sw.Stop();
        Console.WriteLine(sw.ElapsedTicks);
        sw.Reset();
        Assert.Pass();
    }
    [Test]
    public void Test1()
    {
        Assert.AreEqual(0, 0);
    }
}