#include <stdio.h>
#include <iostream>

int sum(int arr[]) 
{
	int total = 0;
	for (int i = 0; i < 4; i++) 
	{
		total += arr[i];
	}
	return total;
}

int main() 
{
	int arr[4] = { 1,2,3,4 };
	std::cout<<sum(arr);

	return 0;
}
