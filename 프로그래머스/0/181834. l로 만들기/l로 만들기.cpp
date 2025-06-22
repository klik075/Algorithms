#include <string>
#include <vector>

using namespace std;

string solution(string myString) {
    string answer = myString;
    for(int i = 0; i < myString.size(); i++)
    {
        if(answer[i] < 'l')
            answer[i] = 'l';
    }
    return answer;
}