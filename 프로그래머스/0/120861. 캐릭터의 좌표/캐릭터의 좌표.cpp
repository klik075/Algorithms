#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<string> keyinput, vector<int> board) {
    vector<int> answer;
    int row = board[0]/2;
    int col = board[1]/2;
    int lr = 0;
    int ud = 0;
    for(auto i : keyinput)
    {
        if(i == "left")
            lr--;
        else if(i == "right")
            lr++;
        else if(i == "up")
            ud++;
        else
            ud--;
        if(lr < -row || lr > row)
        {
            if(lr < 0)
                lr = -row;
            else
                lr = row;
        }
        if(ud < -col || ud > col)
        {
            if(ud < 0)
                ud = -col;
            else
                ud = col;
        }
    }
    answer.push_back(lr);
    answer.push_back(ud);
    return answer;
}