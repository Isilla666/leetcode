using System.Diagnostics;

namespace LeetCode.Tests;

public class UnitTest6 : UnitTest<Solution6>
{
    [Test]
    public void SpeedTest()
    {
        var sw = new Stopwatch();
        sw.Start();
        for(var time = 0; time<1000000; time++)
        {
            task.MaxProfit(new[] { 7, 1, 5, 3, 6, 4 });
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedTicks);
        sw.Reset();
        sw.Start();
        for(var time = 0; time<1000000; time++)
        {
            task.MaxProfit2(new[] { 7, 1, 5, 3, 6, 4 });
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedTicks);
        sw.Reset();
        sw.Start();
        for(var time = 0; time<1000000; time++)
        {
            task.MaxProfit3(new[] { 7, 1, 5, 3, 6, 4 });
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedTicks);
        Assert.Pass();
    }
    [Test]
    public void Test1()
    {
        var t = task.MaxProfit(new[] { 7, 1, 5, 3, 6, 4 });
        Assert.AreEqual(t, 5);
    }
    [Test]
    public void Test2()
    {
        var t = task.MaxProfit(new[] { 7,6,4,3,1});
        Assert.AreEqual(t, 0);
    }
    [Test]
    public void Test3()
    {
        var t = task.MaxProfit(new[] { 7,7,4,3,1});
        Assert.AreEqual(t, 0);
    }
    [Test]
    public void Test4()
    {
        var t = task.MaxProfit(new[] { 7,7,4,3,8});
        Assert.AreEqual(t, 5);
    }
    [Test]
    public void Test5()
    {
        var t = task.MaxProfit(new[] { 7,7,4,3,8,1});
        Assert.AreEqual(t, 5);
    }
    [Test]
    public void Test6()
    {
        var t = task.MaxProfit(new[] { 1,1,4,3,8,1});
        Assert.AreEqual(t, 7);
    }
    [Test]
    public void Test7()
    {
        var t = task.MaxProfit(new[] { 1,4,3,8,1});
        Assert.AreEqual(t, 7);
    }
    [Test]
    public void Test8()
    {
        var t = task.MaxProfit(new[] { 2,4,3,8,1,8});
        Assert.AreEqual(t, 7);
    }
}