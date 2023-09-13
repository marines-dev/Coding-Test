public class Solution {

    public int solution(int n) {
        int num1 = 0;
        int num2 = 1;
        
        for(int i = 2; i <= n ; ++i)
        {
            int temp = num2;
            num2 = (num2 + num1) % 1234567;
            num1 = temp;
        }
        
        return num2;
    }
}