using System.Linq;

public class Solution 
{
    public string solution(string s) 
    {
        string answer = "";
        answer = new string(s.OrderByDescending(arr => arr).ToArray());
        return answer;
    }
}