#include <iostream>
#include <vector>

//using std::cout;
//using std::endl;
using namespace std;

//template <typename T>
int max(vector<int> arr) 
{	
    if (arr.empty()) return 0;
    else if (arr.size()==1) return arr[0];
    /*else if (arr.size()==2)  
	{
	if(arr[0]>arr[1]) return arr[0];
	else return arr[1];
	}*/
	int back=arr.back();
	arr.pop_back();
	
    int sub_max=max(arr);
    
    return back > sub_max ? back : sub_max;
}

int main() {
    vector<int> arr_int(0);
    for(int i=0; i<5; i++)
    {
    arr_int.push_back(i+1);
    }
  //  std::vector<float> arr_float = {0.1, 0.2, 0.3, 0.4, 0.5};

    cout << "Max int: " << max(arr_int) << endl;
  //  cout << "Sum floats: " << sum(arr_float) << endl;
}
