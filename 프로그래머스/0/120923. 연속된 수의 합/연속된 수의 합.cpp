#include <string>
#include <vector>

using namespace std;

vector<int> solution(int num, int total) {
    vector<int> answer;
    int comp = total/num;
    for(int i = 0; i < num; i++)
    {
        int data = comp - (num/2) + i;
        if(num % 2 == 0)
            data++;
        answer.push_back(data);
    }
    return answer;
}