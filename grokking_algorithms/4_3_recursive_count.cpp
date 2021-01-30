#include <iostream>
#include <vector>

//using std::cout;
//using std::endl;
using namespace std;

//template <typename T>

int count(vector<int> arr) 
{	
    if (arr.empty()) return 0;
    arr.pop_back(); 
    return count(arr)+1;
}

int main() {
    vector<int> arr_int(0);
    for(int i=0; i<5; i++)
    {
    arr_int.push_back(i+1);
    }
  //  std::vector<float> arr_float = {0.1, 0.2, 0.3, 0.4, 0.5};

    cout << "Sum ints: " << count(arr_int) << endl;
  //  cout << "Sum floats: " << sum(arr_float) << endl;
}
