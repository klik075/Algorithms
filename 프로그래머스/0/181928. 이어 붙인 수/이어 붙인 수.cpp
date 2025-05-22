#include <string>
#include <vector>

using namespace std;

int solution(vector<int> num_list) {
    int answer = 0;
    string oddstring = "";
    string evenstring = "";
    for(auto num : num_list)
    {
        
        if(num % 2 == 0)
            evenstring += to_string(num);
        else
            oddstring += to_string(num);
    }
    return answer = stoi(evenstring) + stoi(oddstring);
}