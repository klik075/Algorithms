public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        char[] arr = s.ToCharArray();
        int temp = 0;
        for(int i =0 ; i < arr.Length ; i++)
        {
            if(arr[i] >= 65 && arr[i] <= 90)
            {
                temp = arr[i] + n;
                if(temp > 90)
                {
                    temp -= 26;
                }
            }
            else if(arr[i] >= 97 && arr[i] <= 122)
            {
                temp = arr[i] + n;
                if(temp > 122)
                {
                    temp -= 26;
                }
            }
            else if(arr[i] == ' ')
            {
                temp = arr[i];
            }
            arr[i] = (char)temp;

        }
        answer = new string(arr);
        return answer;
    }
}