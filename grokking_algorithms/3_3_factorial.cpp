#include <iostream>

using std::cout;
using std::endl;

int fact(const int& x) 
{
	cout<<x<<endl;
    if (x == 1) return 1;
    return fact(x-1) * x;
}

int main() 
{
    cout << fact(3) << endl;
}
