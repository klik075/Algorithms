#include <string>
#include <vector>
#include <sstream>
using namespace std;

vector<string> solution(vector<string> quiz) {
    vector<string> answer;
    vector<string> arr;
    string temp;
    
    for(int i = 0; i < quiz.size(); i++)
    {
        stringstream ss(quiz[i]);
        while(getline(ss,temp,' '))
            arr.push_back(temp);
        
        int num1 = stoi(arr[0]);
        int num2 = stoi(arr[2]);
        int result = stoi(arr[4]);
        
        if(arr[1] == "-")
            answer.push_back(num1 - num2 == result ? "O" : "X");
        else
            answer.push_back(num1 + num2 == result ? "O" : "X");
        
        arr.clear();
    }
    return answer;
}