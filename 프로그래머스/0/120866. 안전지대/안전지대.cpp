#include <string>
#include <vector>

using namespace std;
bool checkbound(int x, int y, int size)
{
    if(x < 0 || y < 0 || x >= size || y >= size)
        return false;
    
    return true;
}
int solution(vector<vector<int>> board) {
    int answer = 0;
    
    for(int i = 0; i < board.size(); i++)
    {
        for(int j = 0; j < board[i].size(); j++)
        {
            if(board[i][j] == 1)
            {
                for(int r = -1; r <= 1; r++)
                {
                    for(int l = -1; l <= 1; l++)
                    {
                        int x = i + r;
                        int y = j + l;
                        if(checkbound(x, y, board[i].size()))
                        {
                            if(board[x][y] == 0)
                                board[x][y] = 2;
                        }
                    }
                }
            }
        }
    }
    for(auto r : board)
    {
        for(auto i : r)
        {
            if(i == 0)
                answer++;
        }
    }
    return answer;
}