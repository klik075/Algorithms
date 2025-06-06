#include <string>
#include <vector>

using namespace std;

int solution(string myString, string pat) {
    int answer = 0;
    for(int i = 0; i < myString.size() - pat.size() + 1; i++)
    {
        string temp = myString.substr(i, pat.size());
        if(temp == pat)
            answer++;
    }
    return answer;
}