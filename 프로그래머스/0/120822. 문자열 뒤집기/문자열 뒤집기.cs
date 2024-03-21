using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        char[] st = my_string.ToCharArray();
        Array.Reverse(st);
        for(int i = 0; i < st.Length; i++)
            answer += st[i];
        return answer;
    }
}