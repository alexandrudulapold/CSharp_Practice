/*#include <iostream>
#include <vector>
#include <iterator>
#include <algorithm>

using namespace std;


template <typename T>
// Quick Sort
vector<T> quicksort(vector<T> arr) 
{
	// Base case, arrays with 0 or 1 elements are already sorted
	if(arr.size()<2) return arr;
	
	// Recursive case	
	T beg=arr.begin(),  en=arr.end();
	
	T pivot = (( (beg + en) / 2) - 1); // Setam pivot pe la mijloc de arr
	vector <int> less;    // Pentru a stoca elementele mai mici decat pivot
	vector <int> greater; // Pentru a stoca elementele mai mari decat pivot
	
	for(T i=arr.begin(); i<arr.end(); i++)
	{
		if(i==pivot) continue;
		else if(i<pivot) less.push_back(i);
		else greater.push_back(i);
	}
	
	// Sortam vector-urile less si greater
	vector <T> sort_less = quicksort(less);
	vector <T> sort_greater = quicksort(greater);
	
	// Bagam toate elementele in vector-ul sort_less
	sort_less.push_back(pivot);
	sort_less.insert(sort_less.end(), sort_greater.begin(), sort_greater.end());
	
	return sort_less;
}

int main() 
{
//	vector <int> array(0);
//	vector <int> sorted = quicksort(array);
//	
//	// Print result
//	for(int i=0; i<10; i++)
//	{
//		cout<<sorted[i]<<endl;
//	}

	return 0;
}*/






#include <stdio.h>

int partition(int[],int,int);

// Quick Sort
void quick_sort(int *array, int start, int end) {
	if (start < end) {
		int q = partition(array, start, end);
		quick_sort(array, start, q - 1);
		quick_sort(array, q + 1, end);
	}
}
// Partition by pivot
int partition(int *array, int start, int end) {
	int pivot = array[end];
	int i = start - 1;
	int temp = 0;
	for (int j = start; j < end; j++) {
		if (array[j] <= pivot) {
			i++;
			temp = array[i];
			array[i] = array[j];
			array[j] = temp;
		}
	}
	temp = array[i + 1];
	array[i + 1] = array[end];
	array[end] = temp;

	return i + 1;
}

int main(void) {
	int arr[4] = {10, 5, 2, 3};
	quick_sort(arr, 0, 3);
	// Print result
	for (int i = 0; i < 4; i++) {
		printf("%d ", arr[i]);
	}

	return 0;
}
