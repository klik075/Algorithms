#include <string>
#include <vector>
#include <algorithm>
using namespace std;

int solution(vector<vector<int>> dots) {
    int answer = 1;
    
    for(int i = 1; i < dots.size(); i++)
    {
        int x = abs(dots[i][0] - dots[0][0]);
        int y = abs(dots[i][1] - dots[0][1]);
        if(x != 0 && y != 0)
            continue;
        if(x == 0)
            answer *= y;
        else
            answer *= x;
    }

    return answer;
}