using System.Collections.Generic;
using Algorithms.Recursions;
using Xunit;

namespace UnitTests.Algorithms.Recursions
{
    public class BacktrackerTest
    {
        [Theory]
        [InlineData("elapp", new[] {"apple", "mango", "orange"} )]
        public void FindWord(string word, IEnumerable<string> words){
                Assert.True(Backtracker.IsAnagram(word, words));
        }
    }
}