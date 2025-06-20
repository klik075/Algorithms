using System;
using System.Linq;
public class Solution {
    public string solution(string a, string b) {
        string answer = "";
        int carry = 0;
        
        char[] charArrayA = a.ToArray();
        char[] charArrayB = b.ToArray();
        Array.Reverse(charArrayA);
        Array.Reverse(charArrayB);
        
        string rA = new string(charArrayA);
        string rB = new string(charArrayB);

        int len_a = rA.Length;
        int len_b = rB.Length;
        int max_len = len_a > len_b ? len_a : len_b;

        for (int i = 0; i < max_len; ++i) {

            int digit_a = (i < len_a) ? rA[i] - '0' : 0;
            int digit_b = (i < len_b) ? rB[i] - '0' : 0;

            int current_sum = digit_a + digit_b + carry;

            carry = current_sum / 10;
            int current_digit = current_sum % 10;

            answer += current_digit.ToString();
        }

        if (carry > 0) {
            answer += carry;
        }
        char[] result = answer.ToArray();
        Array.Reverse(result);
        
        return new string(result);
    }
}