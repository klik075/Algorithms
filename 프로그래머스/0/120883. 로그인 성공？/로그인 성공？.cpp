#include <string>
#include <vector>

using namespace std;

string solution(vector<string> id_pw, vector<vector<string>> db) {
    string answer = "fail";
    for(int i = 0; i < db.size(); i++)
    {
        if(id_pw[0] == db[i][0])
        {
            answer = "wrong pw";
            
            if(id_pw[1] == db[i][1])
                answer = "login";
        }
    }
    return answer;
}