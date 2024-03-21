using System;

public class Solution {
    public int solution(int n, int k) {
        int answer = 0;
        int nPrice = 12000;
        int kPrice = 2000;
        int ccc = 0;
        for(int i = 1 ; i <= n; i++)
        {
            if(i % 10 == 0)
            {
                ccc += kPrice;
            }
        }
         
        return answer = (n * nPrice) + (kPrice * k) - ccc;
    }
}