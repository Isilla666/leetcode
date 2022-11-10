using System.Diagnostics;

namespace LeetCode.Tests;

public class UnitTest49 : UnitTest<Solution49>
{
    [Test]
    public void SpeedTest()
    {
        var sw = new Stopwatch();
        var pp = new[] { "hos","boo","nay","deb","wow","bop","bob","brr","hey","rye","eve","elf","pup","bum","iva","lyx","yap","ugh","hem","rod","aha","nam","gap","yea","doc","pen","job","dis","max","oho","jed","lye","ram","pup","qua","ugh","mir","nap","deb","hog","let","gym","bye","lon","aft","eel","sol","jab" };
        
        Assert.Pass();
    }
    [Test]
    public void Test1()
    {
        var t = task.GroupAnagrams(new []{"eat","tea","tan","ate","nat","bat"});
        var answer = new List<List<string>>{
            new() { "bat" },
            new() {"nat", "tan"},
            new() {"ate", "eat", "tea"}
        };
        if(answer.Count != t.Count) Assert.Fail();


        var t1 = new List<string>();
        var t2 = new List<string>();
        for (var i = 0; i < answer.Count; i++)
        {
            for (var j = 0; j < t[i].Count; j++)
            {
                t[i][j] = new string(t[i][j].Select(y => y).OrderBy(x => x).ToArray());
            }
            for (var j = 0; j < answer[i].Count; j++)
            {
                answer[i][j] = new string(answer[i][j].Select(y => y).OrderBy(x => x).ToArray());
            }

            if (t[i].Any(x => x != t[i][0]))
            {
                Assert.Fail();
            }

            var ty = t[i][0];
            var ty2 = answer[i][0];
            t1.Add(ty);
            t2.Add(ty2);
        }
        t1 = t1.OrderBy( x => x).ToList();
        t2 = t2.OrderBy( x => x).ToList();
        for (var i = 0; i < t1.Count; i++)
        {
            if (t1[i] != t2[i])
            {
                Assert.Fail();
            }
        }

        Assert.Pass();
    }
}