#include <string>
#include <vector>

using namespace std;

vector<vector<int>> solution(int n) {
    vector<vector<int>> answer(n,vector<int>(n));
    int count = 1;
    int top = 0;
    int bottom = n - 1;
    int left = 0;
    int right = n - 1;
    
    while (top <= bottom && left <= right) {
        for (int j = left; j <= right; ++j) {
            answer[top][j] = count++;
        }
        top++;

        if (top > bottom) break;

        for (int i = top; i <= bottom; ++i) {
            answer[i][right] = count++;
        }
        right--;

        if (left > right) break;

        for (int j = right; j >= left; --j) {
            answer[bottom][j] = count++;
        }
        bottom--;

        if (top > bottom) break;

        for (int i = bottom; i >= top; --i) {
            answer[i][left] = count++;
        }
        left++;
    }

    return answer;
}