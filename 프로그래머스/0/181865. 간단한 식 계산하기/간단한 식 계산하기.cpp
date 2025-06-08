#include <string>
#include <vector>
#include <sstream>
using namespace std;

int solution(string binomial) {
    int answer = 0;
    vector<string> arr;
    stringstream ss(binomial);
    string temp;
    
    while(getline(ss,temp,' '))
        arr.push_back(temp);
    
    int a = stoi(arr[0]);
    int b = stoi(arr[2]);
    
    if(arr[1] == "+")
        answer = a + b;
    else if(arr[1] == "-")
        answer = a - b;
    else
        answer = a * b;
    return answer;
}