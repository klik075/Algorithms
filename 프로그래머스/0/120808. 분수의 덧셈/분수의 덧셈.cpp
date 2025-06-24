#include <string>
#include <vector>
#include <algorithm>
using namespace std;

vector<int> solution(int numer1, int denom1, int numer2, int denom2) {
    vector<int> answer;
    answer.push_back(numer1 * denom2 + numer2 * denom1);
    answer.push_back(denom1 * denom2);
    int min;
    int temp;
    while(true)
    {
        min = std::min(answer[0], answer[1]);
        temp = answer[0];

        for(int i = 2; i <= min; i++)
        {
            if(answer[0] % i == 0 && answer[1] % i == 0)
            {
                answer[0] /= i;
                answer[1] /= i;
                break;
            }
        }

        if(temp == answer[0])
            break;
    }

    return answer;
}