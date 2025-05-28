#include <string>
#include <vector>

using namespace std;

int solution(string my_string, string is_suffix) {
    int answer = 0;
    for(int i = 0; i < my_string.size(); i++)
    {
        string temp = my_string.substr(my_string.size() - 1 - i);
        if(temp == is_suffix)
        {
            answer = 1;
            break;
        }
    }
    return answer;
}