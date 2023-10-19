using System;
public class Solution 
{
    public long solution(long n) 
    {
        long answer = (long)Math.Sqrt(n);

        return (answer * answer == n) ? (answer + 1) * (answer + 1) : -1;
    }
}