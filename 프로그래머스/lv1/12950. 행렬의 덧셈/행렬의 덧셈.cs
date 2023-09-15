public class Solution 
{
    public int[,] solution(int[,] arr1, int[,] arr2) 
    {
        int[,] answer = new int[,] {{}};
        
        int x = arr1.GetLength(0);
        int y = arr2.GetLength(1);
        
        answer = new int[x,y];
        for(int i = 0; i < x; i++)
        {
            for(int j = 0; j < y; j++)
            {
                answer[i,j] = arr1[i,j] + arr2[i,j];
            }
        }
        return answer;
    }
}