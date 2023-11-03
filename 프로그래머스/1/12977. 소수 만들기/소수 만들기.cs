using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;

        for(int i = 0; i < nums.Length - 2; i++)
        {
            for(int j = i + 1; j < nums.Length - 1; j++)
            {
                for(int z = j + 1; z < nums.Length; z++)
                {
                    int sum = nums[i] + nums[j] + nums[z];
                    for(int k = 2; k < sum; k++)
                    {
                        if(sum % k == 0)
                        {
                            break;
                        }
                        else
                        {
                            if(k == sum -1)
                            answer++;
                        }
                    }
                }
            }
        }

        return answer;
    }
}