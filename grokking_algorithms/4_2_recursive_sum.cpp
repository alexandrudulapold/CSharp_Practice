#include <iostream>
#include <vector>

//using std::cout;
//using std::endl;
using namespace std;

//template <typename T>

int sum(vector<int> arr) 
{
    if (arr.empty()) return 0;
    int last_num = arr.back(); // save last number value
    arr.pop_back();  // and remove it from array for next recursive call
    return last_num + sum(arr);
}

int main() {
    vector<int> arr_int(0);
    for(int i=0; i<5; i++)
    {
    arr_int.push_back(i+1);
    }
  //  std::vector<float> arr_float = {0.1, 0.2, 0.3, 0.4, 0.5};

    cout << "Sum ints: " << sum(arr_int) << endl;
  //  cout << "Sum floats: " << sum(arr_float) << endl;
}
