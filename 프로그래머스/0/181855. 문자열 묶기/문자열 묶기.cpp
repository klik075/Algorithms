#include <string>
#include <vector>
#include <unordered_map>
using namespace std;

int solution(vector<string> strArr) {
    int length = 0;
    int maxvalue = 0;
    unordered_map<int,int> map;
    for(auto elem : strArr)
    {
        length = elem.length();
        map[length] = map[length] + 1;
        
        if(map[length] > maxvalue)
            maxvalue = map[length];
    }
    return maxvalue;
}