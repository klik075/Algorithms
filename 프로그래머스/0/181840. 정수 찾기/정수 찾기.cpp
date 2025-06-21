#include <string>
#include <vector>
#include <algorithm>
using namespace std;

int solution(vector<int> num_list, int n) {
    int answer = 0;
    sort(num_list.begin(), num_list.end());
    answer = binary_search(num_list.begin(), num_list.end(), n) == true ? 1 : 0;
    return answer;
}