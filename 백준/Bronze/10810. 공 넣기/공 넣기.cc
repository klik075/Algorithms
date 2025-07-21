#include <iostream>
#include <vector>

using namespace std;

int main()
{
    int N, M;
    int i, j, k;
    cin>> N >> M;
    vector<int> arr(N);
    for(int roop = 0; roop < M; roop++)
    {
        cin>>i>>j>>k;
        for(int c = i;c <= j; c++)
            arr[c-1] = k;
    }
    for(auto elem : arr)
        cout<<elem<<' ';
}