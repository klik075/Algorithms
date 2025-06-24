#include <string>
#include <vector>
#include <algorithm>
using namespace std;

int solution(vector<int> sides) {
    int answer = 0;
    int max = std::max(sides[0], sides[1]);
    int min = std::min(sides[0], sides[1]);
    answer = 2 * min - 1;
    return answer;
}