using System;
public class Solution 
{
    public long solution(int a, int b) 
    {
        long answer = 0;
        (int minValue, int maxValue) = a > b ? (b, a) : (a , b);
        for(int num = minValue; num <= maxValue; num++)
        {
            answer += num;
        }
        return answer;
    }
}