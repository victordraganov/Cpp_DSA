#include<iostream>
#include"Sorter.h"
#include"SortTester.h"
#include"InsertionSorter.h"
#include"MyTestrer.h"
#include"QuickSorter.h"
#include"HeapSorter.h"
#include"BubleSorter.h"
#include<chrono>

using namespace std;

int main() {
	int br = 3;
	Sorter<int>** sorters = new Sorter<int>*[br];
	sorters[0] = new InsertionSorter<int>();
	sorters[1] = new QuickSorter<int>();
	//sorters[2] = new HeapSorter<int>(); It has buggs
	sorters[2] = new BubbleSorter<int>();
	MyTester<int> (sorters, br).getSummary(cout);
	//cout<<sorters[0]->getSortTime()<<endl;
	
	cin.ignore();

	return 0;
}