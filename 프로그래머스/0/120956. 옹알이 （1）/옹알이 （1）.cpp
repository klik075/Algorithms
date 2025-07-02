#include <string>
#include <vector>

using namespace std;

int solution(vector<string> babbling) {
    int answer = 0;
    vector<string> list = {"aya","ye","woo","ma"};
    for(auto& elem : babbling)
    {
        for(auto target : list)
        {
            size_t pos = elem.find(target);
            if(pos != string::npos)
                elem.replace(pos,target.length(),"@");
        }
        size_t pos = elem.find("@");
        while(pos != string::npos)
        {
            elem.replace(pos,1,"");
            pos = elem.find("@", pos);
        }
        
        if(elem.length() == 0)
            answer++;
    }
    return answer;
}