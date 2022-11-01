using System.Diagnostics;

namespace LeetCode.Tests;

public class UnitTest4 : UnitTest<Solution4>
{
    [Test]
    public void SpeedTest()
    {
        var sw = new Stopwatch();
        sw.Start();
        for(var time = 0; time<1000000; time++)
        {
            
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedTicks);
        sw.Reset();
        Assert.Pass();
    }
    [Test]
    public void Test1()
    {
        var t = task.SearchInsert(new[] { 0, 1, 2, 3, 4, 5, 6 }, 3);
        Assert.AreEqual(t, 3);
    }
    [Test]
    public void Test2()
    {
        var t = task.SearchInsert(new[] { 0, 1, 5, 3, 4, 5, 6 }, 5);
        Assert.AreEqual(t, 2);
    }   
    [Test]
    public void Test3()
    {
        var t = task.SearchInsert(new[] { 0, 1, 2, 2, 2, 5, 6 }, 2);
        Assert.AreEqual(t, 2);
    }
    [Test]
    public void Test4()
    {
        var t = task.SearchInsert(new[] { 0, 1, 2, 4, 5, 6, 7,7,7,7,7,1,4,8 }, 3);
        Assert.AreEqual(t, 3);
    }
    [Test]
    public void Test5()
    {
        var t = task.SearchInsert(new[] { 1,3,5,6 }, 7);
        Assert.AreEqual(t, 4);
    }
}