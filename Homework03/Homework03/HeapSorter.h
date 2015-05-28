#pragma once

#include"MySorter.h"

template<typename T>
class HeapSorter : public MySorter<T> {
public:
	virtual void sort(T * data, size_t count);
	virtual unsigned long long getSortTime() const;
private:
	void sift(T * data, size_t l, size_t r);
};

template<typename T>
void HeapSorter<T>::sort(T * data, size_t count) {
	auto begin = chrono::high_resolution_clock::now();

	size_t i;
	for (i = count / 2 + 1; i > 1; i--)
	{
		sift(data, i - 1, count);
		
	}

	for ( i = count -1 ; i >= 1; i--)
	{
		std::swap(data[1], data[i]);
		sift(data, 1, i - 1);
	}

	auto end = chrono::high_resolution_clock::now();
	auto dur = end - begin;
	auto ms = std::chrono::duration_cast<std::chrono::nanoseconds>(dur).count();
	timeForSort = ms;
}

template<typename T>
void HeapSorter<T> ::sift(T * data, size_t l, size_t r) {
	size_t i = l;
	size_t j = i * 2;
	T elem = data[i];
	while (j <= r)
	{
		if (j < r && data[j] < data[j+1])
			j++;

		if (elem >= data[j])
			break;

		data[i] = data[j];
		i = j;
		j *= 2;
	}

	data[i] = elem;
}

template<typename T>
unsigned long long HeapSorter<T>::getSortTime() const {
	return timeForSort;
}