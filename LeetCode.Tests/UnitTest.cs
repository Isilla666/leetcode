using System.Diagnostics;

namespace LeetCode.Tests;

public class UnitTest<T> where T : new()
{
    protected T task;

    [SetUp]
    public void Setup()
    {
        task = new T();
    }

}