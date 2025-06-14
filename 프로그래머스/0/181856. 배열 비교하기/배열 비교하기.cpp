#include <string>
#include <vector>

using namespace std;

int solution(vector<int> arr1, vector<int> arr2) {
    int answer = 0;
    int num1 = 0;
    int num2 = 0;
    answer = arr1.size() > arr2.size() ? 1 : -1;
    if(arr1.size() == arr2.size())
    {
        for(int i = 0; i < arr1.size(); i++)
        {
            num1 += arr1[i];
            num2 += arr2[i];
        }
        answer = num1 > num2 ? 1 : -1;
        if(num1 == num2)
            answer = 0;
    }
    return answer;
}