#include <iostream>
using namespace std;

int main()
{
    std::ios_base::sync_with_stdio(false);
    std::cin.tie(NULL); 
    int t = 0;
    cin>>t;
    for(int i = 0; i < t; i++)
    {
        int a, b;
        cin>>a>>b;
        cout<<a+b<<'\n';
    }
}