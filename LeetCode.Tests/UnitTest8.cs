using System.Diagnostics;

namespace LeetCode.Tests;

public class UnitTest8 : UnitTest<Solution8>
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
        var t = task.IsValid("()");
        Assert.AreEqual(t, true);
    }
    [Test]
    public void Test2()
    {
        var t = task.IsValid("()[]{}");
        Assert.AreEqual(t, true);
    }
    [Test]
    public void Test3()
    {
        var t = task.IsValid("(]");
        Assert.AreEqual(t, false);
    }
    [Test]
    public void Test4()
    {
        var t = task.IsValid("()()()()");
        Assert.AreEqual(t, true);
    }
    [Test]
    public void Test5()
    {
        var t = task.IsValid("}{");
        Assert.AreEqual(t, false);
    }
    [Test]
    public void Test6()
    {
        var t = task.IsValid("}[)");
        Assert.AreEqual(t, false);
    }
    [Test]
    public void Test7()
    {
        var t = task.IsValid("{}(]");
        Assert.AreEqual(t, false);
    }
    [Test]
    public void Test8()
    {
        var t = task.IsValid("()[[");
        Assert.AreEqual(t, false);
    }
    [Test]
    public void Test9()
    {
        var t = task.IsValid("()[]{}");
        Assert.AreEqual(t, true);
    }
    [Test]
    public void Test10()
    {
        var t = task.IsValid("}})}({{]{");
        Assert.AreEqual(t, false);
    }
    [Test]
    public void Test11()
    {
        var t = task.IsValid("()()[]{})(");
        Assert.AreEqual(t, false);
    }
    [Test]
    public void Test12()
    {
        var t = task.IsValid("{}()()[](){}");
        Assert.AreEqual(t, true);
    }

    [Test]
    public void Test13()
    {
        var t = task.IsValid("][");
        Assert.AreEqual(t, false);
    }
    [Test]
    public void Test14()
    {
        var t = task.IsValid("([]){}");
        Assert.AreEqual(t, true);
    }
    [Test]
    public void Test15()
    {
        var t = task.IsValid("([)]");
        Assert.AreEqual(t, false);
    }
}