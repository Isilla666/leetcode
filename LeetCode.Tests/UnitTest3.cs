using System.Diagnostics;

namespace LeetCode.Tests;

public class UnitTest3
{
    private Solution3 _task;

    [SetUp]
    public void Setup()
    {
        _task = new Solution3();
    }

    [Test]
    public void SpeedTest()
    {
        var sw = new Stopwatch();
        sw.Start();
        for(var time = 0; time<1000000; time++)
        {
            var num = new[] { 0,1,2,2,3,0,4,2};
            var t = _task.RemoveDuplicates(ref num);
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedTicks);
        sw.Reset();
        Assert.Pass();
    }
    [Test]
    public void Test1()
    {
        var num = new[] { 3, 2, 2, 3 };
        var t = _task.RemoveDuplicates(ref num);
        Assert.AreEqual(t, 2);
    }
    [Test]
    public void Test2()
    {
        var num = new[] { 0,1,2,2,3,0,4,2};
        var t = _task.RemoveDuplicates(ref num);
        Assert.AreEqual(t, 5);
    }
    [Test]
    public void Test3()
    {
        var num = new[] { 3, 2, 2, 3 };
        var num2 = new[] { 3, 2, 2, 3 };
        var t = _task.RemoveDuplicates(ref num);
        var tt = num2.Distinct().ToArray();
        var ttt = num.Take(t).ToArray();
        var outp = ttt.SequenceEqual(tt);
        Assert.AreEqual(outp, true);
    }
    [Test]
    public void Test4()
    {
        var num = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };
        var num2 = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };
        var t = _task.RemoveDuplicates(ref num);
        var tt = num2.Distinct().ToArray();
        var ttt = num.Take(t).ToArray();
        var outp = ttt.SequenceEqual(tt);
        Assert.AreEqual(outp, true);
    }
    [Test]
    public void Test5()
    {
        var num = new[] { 0, 0, 0, 2, 3, 0, 4, 2 };
        var num2 = new[] { 0, 0, 0, 2, 3, 0, 4, 2 };
        var t = _task.RemoveDuplicates(ref num);
        var tt = num2.Distinct().ToArray();
        var ttt = num.Take(t).ToArray();
        var outp = ttt.SequenceEqual(tt);
        Assert.AreEqual(outp, true);
    }
    [Test]
    public void Test6()
    {
        var num = new[] { 0, 0};
        var num2 = new[] { 0, 0};
        var t = _task.RemoveDuplicates(ref num);
        var tt = num2.Distinct().ToArray();
        var ttt = num.Take(t).ToArray();
        var outp = ttt.SequenceEqual(tt);
        Assert.AreEqual(outp, true);
    }
    [Test]
    public void Test7()
    {
        var num = new[] { 0,0,2,2,3,0,4,2};
        var t = _task.RemoveDuplicates(ref num);
        Assert.AreEqual(t, 4);
    }
    [Test]
    public void Test8()
    {
        var num = new[] { 0,0};
        var t = _task.RemoveDuplicates(ref num);
        Assert.AreEqual(t, 1);
    }
}