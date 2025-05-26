#include <string>
#include <vector>

using namespace std;

vector<int> solution(int l, int r) {
    vector<int> answer;
    for(int num = l; num <= r; num++)
    {
        int div = 1;
        while((num / div) % 5 == 0 && div <= num)
            div *= 10;

        if((num / div) % 5 == 0)
            answer.push_back(num);
    }
    if(answer.size() == 0)
        answer.push_back(-1);

    return answer;
}