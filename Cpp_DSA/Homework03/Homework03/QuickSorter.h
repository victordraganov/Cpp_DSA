#pragma once

#include"MySorter.h"

template<typename T>
class QuickSorter : public MySorter<T> {
public:
	virtual void sort(T * data, size_t count);
	virtual unsigned long long getSortTime() const;
private:
	void justSort(T * data, size_t count);
	size_t partition(T* data, size_t count);
};

template<typename T>
void QuickSorter<T>::sort(T * data, size_t count) {
	auto begin = chrono::high_resolution_clock::now();

	justSort(data, count);

	auto end = chrono::high_resolution_clock::now();
	auto dur = end - begin;
	auto ms = std::chrono::duration_cast<std::chrono::nanoseconds>(dur).count();
	timeForSort = ms;
}

template<typename T>
void QuickSorter<T>::justSort(T * data, size_t count)
{
	if (count <= 1 || !data)
		return;

	size_t position = partition(data, count);

	justSort(data, position);
	justSort(data + position + 1, count - position - 1);
}

template<typename T>
size_t QuickSorter<T>::partition(T* data, size_t count)
{
	assert(count >= 2);
	if (count == 2)
	{
		SwapIf(data[0], data[1]);
		return 1;
	}

	size_t mid = count / 2;
	SwapIf(data[0], data[mid]);
	SwapIf(data[0], data[count - 1]);
	SwapIf(data[mid], data[count - 1]);

	std::swap(data[mid], data[count - 2]);

	T& partEl = data[count - 2];

	size_t l = 0;
	size_t r = count - 2;

	while (true)
	{
		while (data[++l] < partEl)
		{;}
		
		while (data[--r] > partEl)
		{
			if (l == r)
			{
				break;
			}
		}

		if (l >= r)
		{
			break;
		}

		std::swap(data[l], data[r]);
	}

	std::swap(data[l], partEl);

	return l;
}

template<typename T>
unsigned long long QuickSorter<T>::getSortTime() const {
	return timeForSort;
}