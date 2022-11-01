using System.Diagnostics;

namespace LeetCode.Tests;

public class UnitTest1 : UnitTest<Solution1>
{
    [Test]
    public void SpeedTest()
    {
        int[] t = {0,1};
        var sw =new Stopwatch();
        sw.Start();
        for(var time = 0; time<1000000; time++)
        {
            t = task.TwoSum(new []{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,3, 3}, 6);
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedTicks);
        Assert.AreEqual(t, new[] { 15, 16 });
    }

    [Test]
    public void Test1()
    {
        var t = task.TwoSum(new []{2,7,11,15}, 9);
        Assert.AreEqual(t, new[] { 0, 1 });
    }
    [Test]
    public void Test2()
    {
        var t = task.TwoSum(new []{3,2,4}, 6);
        Assert.AreEqual(t, new[] { 1, 2 });
    }
    [Test]
    public void Test3()
    {
        var t = task.TwoSum(new []{3,3}, 6);
        Assert.AreEqual(t, new[] { 0, 1 });
    }
    [Test]
    public void Test4()
    {
        var t = task.TwoSum(new []{1,1,1,1,1,3, 3}, 6);
        Assert.AreEqual(t, new[] { 5, 6 });
    }
    [Test]
    public void Test5()
    {
        var t = task.TwoSum(new []{1,1,1,1,3,1, 3}, 6);
        Assert.AreEqual(t, new[] { 4, 6 });
    }
    [Test]
    public void Test6()
    {
        var t = task.TwoSum(new []{1,1,1,1,3,3, 3}, 6);
        Assert.AreEqual(t, new[] { 4, 5 });
    }
    
}