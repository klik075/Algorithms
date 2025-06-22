#include <string>
#include <vector>

using namespace std;

vector<string> solution(vector<string> picture, int k) {
    vector<string> answer(picture.size() * k);
    for(int i = 0; i < answer.size(); i++)
    {
        string temp = picture[i/k];
        string result = "";
        for(int j = 0; j < temp.size(); j++)
        {
            for(int m = 0 ; m < k; m++)
            {
                char ch = temp[j];
                result += ch;
            }
        }
        answer[i] = result;
    }
    return answer;
}