using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Recursions
{
    public static class Backtracker
    {
        public static bool IsAnagram(string word, IEnumerable<string> words){
            return IsAnagram(string.Empty, word, words);
        }

        static bool IsAnagram(string soFar, string rest, IEnumerable<string> words){
            if (string.IsNullOrEmpty(rest))
            return words.Contains(soFar);
            else{
                for(int i = 0; i<rest.Length;i++){
                    var remaining = rest.Substring(0,i) + rest.Substring(i+1);
                    if (IsAnagram(soFar + rest[i], remaining, words)){
                        return true;
                    }
                }
                return false;
            }
        }
    }
}