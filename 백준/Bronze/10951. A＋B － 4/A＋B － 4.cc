#include <iostream>

using namespace std;
int main() 
{
    std::ios_base::sync_with_stdio(false); 
    std::cin.tie(NULL);
    int a, b;
    
    while (std::cin >> a >> b) 
        cout << a + b << '\n';
    
    return 0;
}