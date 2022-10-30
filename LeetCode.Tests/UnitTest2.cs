using System.Diagnostics;

namespace LeetCode.Tests;

public class UnitTest2
{
    private Solution2 _task;

    [SetUp]
    public void Setup()
    {
        _task = new Solution2();
    }

    [Test]
    public void SpeedTest()
    {
        var sw = new Stopwatch();
        sw.Start();
        for(var time = 0; time<1000000; time++)
        {
            var num = new[] { 3, 2, 2, 3 };
            _task.RemoveElement(ref num, 3);
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedTicks);
        Assert.Pass();
    }
    [Test]
    public void Test1()
    {
        var num = new[] { 3, 2, 2, 3 };
        var t = _task.RemoveElement(ref num, 3);
        Assert.AreEqual(t, 2);
    }
    [Test]
    public void Test2()
    {
        var num = new[] { 0,1,2,2,3,0,4,2};
        var t = _task.RemoveElement(ref num, 2);
        Assert.AreEqual(t, 5);
    }
    [Test]
    public void Test3()
    {
        var num = new[] { 3, 2, 2, 3 };
        var t = _task.RemoveElement(ref num, 3);
        var outp = !num.Take(t).Contains(3);
        Assert.AreEqual(outp, true);
    }
    [Test]
    public void Test4()
    {
        var num = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };
        var t = _task.RemoveElement(ref num, 2);
        var outp = !num.Take(t).Contains(2);
        Assert.AreEqual(outp, true);
    }
    
}