#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> arr) {
    vector<int> stk;
    for(int i = 0; i < arr.size(); )
    {
        if(i < arr.size())
        {
            if(stk.size() == 0)
            {
                stk.push_back(arr[i++]);   
            }
            else
            {
                if(stk[stk.size() - 1] < arr[i])
                    stk.push_back(arr[i++]);
                else
                    stk.pop_back();
            }
        }
    }
    return stk;
}