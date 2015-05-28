#include"MySorter.h"

template<typename T>
class BubbleSorter : public MySorter<T> {
public:
	virtual void sort(T * data, size_t count);
	virtual unsigned long long getSortTime() const;
};

template<typename T>
void BubbleSorter<T>::sort(T* data, size_t count)
{
	if (!data || count == 0)
		return;

	T temp;

	for (size_t i = 0; i < count - 1; i++)
	{
		for (size_t j = count - 1; j > i; j--)
		{
			if (data[j] < data[j -1])
			{
				temp = data[j - 1];
				data[j - 1] = data[j];
				data[j] = temp;
			}
			
		}
	}
}

template<typename T>
unsigned long long BubbleSorter<T>::getSortTime() const {
	return timeForSort;
}