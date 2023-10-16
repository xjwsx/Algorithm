using System;

public class Solution 
{
    public int solution(int a, int b, int n) 
    {
        int answer = 0;
        
        while (n >= a)
        {
            int temp = (n / a) * b;
            int temps = n % a;
            
            n = temp + temps;
            answer += temp;
        }
        return answer;
    }
}