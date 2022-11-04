using System.Diagnostics;

namespace LeetCode.Tests;

public class UnitTest7 : UnitTest<Solution7>
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
        var t = task.RomanToInt("III");
        Assert.AreEqual(t, 3);
    }
    [Test]
    public void Test2()
    {
        var t = task.RomanToInt("LVIII");
        Assert.AreEqual(t, 58);
    }
    [Test]
    public void Test3()
    {
        var t = task.RomanToInt("MCMXCIV");
        Assert.AreEqual(t, 1994);
    }
    [Test]
    public void Test4()
    {
        var t = task.RomanToInt("MCMXCV");
        Assert.AreEqual(t, 1995);
    }
    [Test]
    public void Test5()
    {
        var t = task.RomanToInt("MCMXCVI");
        Assert.AreEqual(t, 1996);
    }
    [Test]
    public void Test6()
    {
        var t = task.RomanToInt("MCMXC");
        Assert.AreEqual(t, 1990);
    }
    [Test]
    public void Test7()
    {
        var t = task.RomanToInt("MCMXV");
        Assert.AreEqual(t, 1915);
    }
}