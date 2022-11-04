using System.Diagnostics;

namespace LeetCode.Tests;

public class UnitTest9 : UnitTest<Solution9>
{
    [Test]
    public void SpeedTest()
    {
        var sw = new Stopwatch();
        sw.Start();
        /*for(var time = 0; time<1000000; time++)
        {
            task.IsAnagram("anagram", "nagaram");
        }*/
        sw.Stop();
        Console.WriteLine(sw.ElapsedTicks);
        sw.Reset();
        Assert.Pass();
    }
    [Test]
    public void Test1()
    {
        var t = task.IsAnagram("anagram", "nagaram");
        Assert.AreEqual(t, true);
    }
    [Test]
    public void Test2()
    {
        var t = task.IsAnagram("rat", "car");
        Assert.AreEqual(t, false);
    }
    [Test]
    public void Test3()
    {
        var t = task.IsAnagram("zlap", "kcqx");
        Assert.AreEqual(t, false);
    }
}