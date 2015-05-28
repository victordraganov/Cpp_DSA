#pragma once

#include "SortTester.h"
#include <assert.h>

template<class T>
class MyTester : public SortTester < T >
{
public:
	MyTester(Sorter<T> ** sorters, int count) : SortTester<T>(sorters, count)
	{
		sortersAddr = sorters;
		sortersCnt = count;
		
		br = 10000;
		array = new T[br];
		for (size_t i = 0; i < br; i++)
		{
			array[i] = (T)(rand() % br);
		}
		
		for (size_t t = 0; t < count; t++)
		{
			T* temp = new T[br];
			for (size_t j = 0; j < br; j++)
			{
				temp[j] = array[j];
			}
			sorters[t]->sort(temp, br);
			assert(IsSorted(temp, br));
			delete[] temp;
		}
		
	}
	virtual void getSummary(std::ostream & out)
	{
		for (size_t i = 0; i < sortersCnt; i++)
		{
			out << "Time for sort " << i + 1 <<": "<< sortersAddr[i]->getSortTime() << endl;
		}
	}

	~MyTester()
	{
		if (array)
			delete[] array;

	}
private:
	T* array;
	int br;
	Sorter<T>** sortersAddr;
	int sortersCnt;

	bool IsSorted(T* arr, int cnt)
	{
		for (size_t i = 0; i < cnt-1; i++)
		{
			if (arr[i]>arr[i + 1])
				return false;
		}
		return true;
	}
	
};