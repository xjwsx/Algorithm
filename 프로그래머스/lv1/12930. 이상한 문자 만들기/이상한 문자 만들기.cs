public class Solution 
{
    public string solution(string s) 
    {
        string answer = "";
        int count = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == ' ')
            {
                answer += s[i];
                count = 0;
                continue;
            }
            if(count % 2 == 0)
            {
                answer += s[i].ToString().ToUpper();
                count++;
            }
            else
            {
                answer += s[i].ToString().ToLower();
                count++;
            }
        }
        return answer;
    }
}