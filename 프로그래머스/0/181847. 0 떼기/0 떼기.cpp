#include <string>
#include <vector>

using namespace std;

string solution(string n_str) {
    string answer = "";
    bool trigger = false;
    for(int i = 0; i < n_str.size(); i++)
    {
        if(!trigger && n_str[i] == '0')
            continue;
        else
            trigger = true;
            
        answer += n_str[i];
    }
    return answer;
}