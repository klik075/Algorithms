#include <string>
#include <vector>

using namespace std;

vector<int> solution(string my_string) {
    vector<int> answer;
    answer.reserve(52);
    
    for(int i = 0; i < 52; i++)
        answer.push_back(0);
    
    for(int i = 0; i < my_string.size(); i++)
    {
        char ch = my_string[i];
        if(65 <= ch && ch <= 95)
            answer[ch - 65] += 1;
        else if(97 <= ch && ch <= 122)
            answer[ch - 97 + 26] += 1;
    }
    return answer;
}