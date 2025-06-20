#include <string>
#include <vector>
#include <algorithm>
using namespace std;

string solution(string a, string b) {
    string answer = "";
    int carry = 0;
    
    reverse(a.begin(), a.end());
    reverse(b.begin(), b.end());

    int len_a = a.length();
    int len_b = b.length();
    int max_len = max(len_a, len_b);

    for (int i = 0; i < max_len; ++i) {
        
        int digit_a = (i < len_a) ? a[i] - '0' : 0;
        int digit_b = (i < len_b) ? b[i] - '0' : 0;

        int current_sum = digit_a + digit_b + carry;

        carry = current_sum / 10;
        int current_digit = current_sum % 10;

        answer += to_string(current_digit);
    }

    if (carry > 0) {
        answer += to_string(carry);
    }

    reverse(answer.begin(), answer.end());

    return answer;
}