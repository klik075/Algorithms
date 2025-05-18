#include <iostream>
#include <string>
#include <cctype>
using namespace std;

int main(void) {
    string str;
    cin >> str;
    for(char& c : str)
    {
        if(isupper(c))
        {
            c = tolower(c);
        }
        else
        {
            c = toupper(c);        
        }
    }
    cout << str;
    return 0;
}