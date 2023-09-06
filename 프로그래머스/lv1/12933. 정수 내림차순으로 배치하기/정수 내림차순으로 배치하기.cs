using System;
using System.Linq;
public class Solution 
{
    public long solution(long n) 
    {
        long answer = 0;
        char[] aa = n.ToString().ToCharArray();
        Array.Sort(aa);
        Array.Reverse(aa);
        answer = long.Parse(aa);
        return answer;
    }
}