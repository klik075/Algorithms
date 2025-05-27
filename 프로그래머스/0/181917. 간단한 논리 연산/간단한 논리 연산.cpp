#include <string>
#include <vector>

using namespace std;

bool solution(bool x1, bool x2, bool x3, bool x4) {
    bool answer = false;
    if(x1 == true || x2 == true)
        answer = true;
    else
    {
        answer = false;
        return answer;
    }
    if(x3 == true || x4 == true)
        answer = true;
    else
        answer = false;
    return answer;
}