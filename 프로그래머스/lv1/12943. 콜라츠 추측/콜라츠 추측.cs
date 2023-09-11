public class Solution 
{
    public int solution(int num) 
    {
        int answer = 0;
        long temp = num;
        while(answer <= 500)
        {
            if(temp == 1)
            {
                break;
            }
            if(temp % 2 == 0)
            {
                temp = temp / 2;
            }
            else
            {
                temp = temp * 3 + 1;
            }
            answer++;
        }
        if(temp != 1)
        {
            return -1;
        }
        return answer;
    }
}