using System;

class Solution
{
    public long solution(int price, long money, int count)
    {
        long total = 0;
        for(int i = 1; i <= count; i++)
        {
            total += i * price;
        }
        return (total - money) < 0 ? 0 : total - money;
    }
}