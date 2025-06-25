#include <string>
#include <vector>
#include <algorithm>
using namespace std;

int solution(vector<string> spell, vector<string> dic) {
    int answer = 2;
    for(auto d : dic)
    {
        bool isin = true;
        for(auto s : spell)
        {
            int it = d.find(s);
            if(it == string::npos)
            {
                isin = false;
                break;
            }
        }
        if(isin)
        {
            answer = 1;
            break;
        }
    }
    return answer;
}