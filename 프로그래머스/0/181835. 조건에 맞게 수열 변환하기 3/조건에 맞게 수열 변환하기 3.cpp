#include <string>
#include <vector>
#include <algorithm>
using namespace std;

vector<int> solution(vector<int> arr, int k) {
    vector<int> answer(arr.size());
    transform(arr.begin(),arr.end(),answer.begin(),[k](int a){
        if(k % 2 == 0)
            return a + k;
        else
            return a * k;
    });
    return answer;
}