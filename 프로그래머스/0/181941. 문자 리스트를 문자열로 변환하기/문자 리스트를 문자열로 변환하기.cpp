#include <string>
#include <vector>

using namespace std;

string solution(vector<string> arr) {
    string answer = "";
    for(auto elem : arr)
        answer += elem;
    return answer;
}