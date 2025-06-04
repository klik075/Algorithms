#include <string>
#include <vector>

using namespace std;

int solution(vector<int> num_list) {
    int answer = 0;
    for(auto elem : num_list)
    {
        int num = elem;
        while(num != 1)
        {
            answer++;
            if(num % 2 == 0)
                num /= 2;
            else
                num = (num - 1) / 2;
        }
    }
    return answer;
}