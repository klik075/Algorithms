#include <iostream>
#include <string>

using namespace std;

int main(void) {
    string str1, str2;
    string str3;
    cin >> str1 >> str2;
    str3.append(str1);
    str3.append(str2);
    cout<<str3<<endl;
    return 0;
}