using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] arr) 
    {
        int[] answer = new int[] {};
        List<int> arrList = new List<int>();
        int min = arr.Min();
        if(arr.Length <= 1)
        {
            arrList.Add(-1);
            answer = arrList.ToArray();
        }
        for(int i = 0; i < arr.Length; i++)
        {
            arrList.Add(arr[i]);
            arrList.Remove(min);
            answer = arrList.ToArray();
        }
        return answer;
    }
}