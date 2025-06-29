#include <string>
#include <vector>
#include <sstream> 
using namespace std;

string solution(string polynomial) {
    string answer = "";
    stringstream ss(polynomial);
    string temp = "";
    vector<string> data;
    int xCount = 0;
    int numCount = 0;
    
    while(getline(ss,temp,' '))//분리
        data.push_back(temp);
    
    for(string s : data)
    {
        auto it = s.find('x');
        if(it != string::npos)
        {
            if(it == 0)
                xCount++;
            else
            {
                s.replace(it, 1, "");
                xCount += stoi(s);
            }
        }
        else if(s != "+")
            numCount += stoi(s);
    }
    if(xCount != 0)
    {
        if(xCount == 1)
            answer += "x";
        else
            answer += to_string(xCount) + "x";
        
        if(numCount != 0)
            answer += " + ";
    }
    if(numCount != 0)
        answer += to_string(numCount);
    return answer;
}