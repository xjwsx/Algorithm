using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] answers) 
    {
        int[] answer1 = new int[] {1,2,3,4,5};
        int[] answer2 = new int[] {2,1,2,3,2,4,2,5};
        int[] answer3 = new int[] {3,3,1,1,2,2,4,4,5,5};
        int[] count = new int[3];
        
        for(int i = 0; i < answers.Length; i++)
        {
            if(answers[i] == answer1[i % answer1.Length]) count[0]++;
            if(answers[i] == answer2[i % answer2.Length]) count[1]++;
            if(answers[i] == answer3[i % answer3.Length]) count[2]++;
        }
        List<int> list = new List<int>();
        if(count[0] == count.Max() ) list.Add(1);
        if(count[1] == count.Max() ) list.Add(2);
        if(count[2] == count.Max() ) list.Add(3);
        return list.ToArray();
    }
}