#include <iostream>
#include <string>

using namespace std;

int main(void) {
    string str;
    string result;
    int n;
    cin >> str >> n;
    for(int i = 0; i < n; i++)
    {
         result.append(str);
    }
    cout << result << endl;
    return 0;
}