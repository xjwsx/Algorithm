public class Solution 
{
    public string solution(int a, int b) 
    {
        string answer = "";
        string[] weeks = new string[] {"FRI","SAT","SUN","MON","TUE","WED","THU"};
        int[] days = new int[] {31,29,31,30,31,30,31,31,30,31,30,31};
        int totals = 0;
        for(int i = 0; i < a -1; i++)
        {
            totals += days[i];
        }
        totals += b - 1;
        answer = weeks[totals % 7];
        
        
        return answer;
    }
}