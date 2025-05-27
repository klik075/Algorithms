#include <string>
#include <vector>
#include <cstdlib>
#include <algorithm>
#include<math.h>
using namespace std;

int solution(int a, int b, int c, int d) {
    int answer = 0;
    if(a == b && b == c && c == d)
        answer = 1111 * a;
    else if(a == b && b == c)
        answer = pow((10 * a + d),2);
    else if(b == c && c == d)
        answer = pow((10 * b + a),2);
    else if(c == d && d == a)
        answer = pow((10 * c + b),2);
    else if(d == a && a == b)
        answer = pow((10 * d + c),2);
    else if(a == b && c == d)
        answer = (a + c) * abs(a - c);
    else if(a == c && b == d)
        answer = (a + b) * abs(a - b);
    else if(a == d && b == c)
        answer = (a + b) * abs(a - b);
    else if(a == b)
        answer = c * d;
    else if(a == c)
        answer = b * d;
    else if(a == d)
        answer = b * c;
    else if(b == c)
        answer = a * d;
    else if(b == d)
        answer = a * c;
    else if(c == d)
        answer = a * b;
    else
        answer = min(a,b) < min(c,d) ? min(a,b) : min(c,d);
        
    return answer;
}