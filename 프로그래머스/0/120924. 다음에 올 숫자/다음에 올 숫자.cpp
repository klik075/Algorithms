#include <string>
#include <vector>

using namespace std;

int solution(vector<int> common) {
    int last = common[common.size() - 1];
    int dif = common[1] - common[0];
    int mul;
    
    if(common[0] == 0 && dif == 0)
        return 0;
    
    mul = common[2] / common[1];
    
    for(int i = 1; i < common.size(); i++)
    {
        if(common[i] - common[i-1] != dif)
            return last * mul;
    }
    
    return last + dif;
}