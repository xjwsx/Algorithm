using System.Linq;
public class Solution 
{
    public string[] solution(string[] strings, int n) 
    {
        string[] answer = new string[] {};
        answer = strings.OrderBy(x => x).OrderBy(x => x[n]).ToArray();
        return answer;
    }
}