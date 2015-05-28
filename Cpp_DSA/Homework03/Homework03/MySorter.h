#pragma once

#include"Sorter.h"
#include<assert.h>

template<typename T>
class MySorter : public Sorter<T> {
public:
	virtual void sort(T * data, size_t count) = 0;
	virtual unsigned long long getSortTime() const = 0;
protected:
	unsigned long long timeForSort;

};

template<typename T>
void SwapIf(T& x, T& y)
{
	if (y < x)
	{
		T temp(x);
		x = y;
		y = temp;
	}
}