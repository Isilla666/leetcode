using System.Diagnostics;

namespace LeetCode.Tests;

public class UnitTest5 : UnitTest<Solution5>
{
    [Test]
    public void SpeedTest()
    {
        var sw = new Stopwatch();
        sw.Start();
        /*for(var time = 0; time<1000000; time++)
        {
            _task.PlusOne(new[] { 1, 5, 8 });
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedTicks);
        sw.Reset();
        sw.Start();
        for(var time = 0; time<1000000; time++)
        {
            task.PlusOne2(new[] { 1, 5, 8 });
        }*/
        sw.Stop();
        Console.WriteLine(sw.ElapsedTicks);
        Assert.Pass();
    }
    [Test]
    public void Test1()
    {
        var t = task.PlusOne(new[] { 1, 5, 8 });
        Assert.AreEqual(t, new[] { 1, 5, 9 });
    }
}