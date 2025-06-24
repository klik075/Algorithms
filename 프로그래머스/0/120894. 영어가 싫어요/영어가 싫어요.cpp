#include <string>
#include <vector>

using namespace std;

long long solution(string numbers) {
    long long answer = 0;
    vector<string> arr = {"zero","one", "two", "three", "four", "five", "six","seven","eight","nine"};
    bool escape = false;
    while(!escape)
    {
        escape = true;
        auto it = numbers.find(arr[0]);
        if(it != string::npos)
        {
            numbers.replace(it, arr[0].length(), "0");
            escape = false;
        }
        it = numbers.find(arr[1]);
        if(it != string::npos)
        {
            numbers.replace(it, arr[1].length(), "1");
            escape = false;
        }
        it = numbers.find(arr[2]);
        if(it != string::npos)
        {
            numbers.replace(it, arr[2].length(), "2");
            escape = false;
        }
        it = numbers.find(arr[3]);
        if(it != string::npos)
        {
            numbers.replace(it, arr[3].length(), "3");
            escape = false;
        }
        it = numbers.find(arr[4]);
        if(it != string::npos)
        {
            numbers.replace(it, arr[4].length(), "4");
            escape = false;
        }
        it = numbers.find(arr[5]);
        if(it != string::npos)
        {
            numbers.replace(it, arr[5].length(), "5");
            escape = false;
        }
        it = numbers.find(arr[6]);
        if(it != string::npos)
        {
            numbers.replace(it, arr[6].length(), "6");
            escape = false;
        }
        it = numbers.find(arr[7]);
        if(it != string::npos)
        {
            numbers.replace(it, arr[7].length(), "7");
            escape = false;
        }
        it = numbers.find(arr[8]);
        if(it != string::npos)
        {
            numbers.replace(it, arr[8].length(), "8");
            escape = false;
        }
        it = numbers.find(arr[9]);
        if(it != string::npos)
        {
            numbers.replace(it, arr[9].length(), "9");
            escape = false;
        }
            
    }
    answer = stoll(numbers);
        
    return answer;
}