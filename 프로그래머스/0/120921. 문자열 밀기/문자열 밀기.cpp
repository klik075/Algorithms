#include <string>
#include <vector>

using namespace std;

int solution(string A, string B) {
    int answer = 0;
    
    if(A != B)
    {
        answer = 1;
        for(int i = 0; i < A.size() - 1; i++)
        {
            char last = A[A.size() - 1];
            string tail = A.substr(0, A.size() - 1);
            string result = last + tail;
            A = result;
            
            if(result == B)
                break;
            
            answer++;
        }
    }
    return answer > A.size() - 1 ? -1 : answer;
}