#pragma once

#include"MySorter.h"

template<typename T>
class InsertionSorter : public MySorter<T> {
public:
	virtual void sort(T * data, size_t count);
	virtual unsigned long long getSortTime() const;
};

template<typename T>
void InsertionSorter<T>::sort(T * data, size_t count) {
	auto begin = chrono::high_resolution_clock::now();

	T elem;
	size_t j;
	for (size_t i = 0; i < count; i++)
	{
		elem = data[i];
		j = i - 1;
		while (j >= 0 && elem < data[j]) {
			data[j + 1] = data[j--];
			data[j + 1] = elem;
		}
	}
	auto end = chrono::high_resolution_clock::now();
	auto dur = end - begin;
	auto ms = std::chrono::duration_cast<std::chrono::nanoseconds>(dur).count();
	timeForSort = ms;
}

template<typename T>
unsigned long long InsertionSorter<T>::getSortTime() const {
	return timeForSort;
}