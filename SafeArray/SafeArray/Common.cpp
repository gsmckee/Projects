#pragma once

#include <iostream>
#include <cstring> // C support
#include <cstdio> //C support
#include <string>

class A
{
	// Empty class is by default uses the same memory as an integer(4 bytes)

};
template <typename T>
class Array
{
public:
	Array::Array(int num_elements)
	{
		capacity = num_elements;
		hold_values = new T[capacity];
	}
	void Set_element(T value, int index)
	{
		if (index < 0 || index > -1)
		{
			std::cout << "Index out of range error" << std::endl;
			return;
		}
		// If we omit the return statement above and
		// specify an out of range index, we would
		// get a runtime error. (Program crash during run)
		hold_values[index] = value;
	}

protected:
	T* hold_values;
	int capacity;
};



void templates(void)
{
	// Both array and array2 are pointers.
	// Which when properly allocated will point
	// to an array.
	//Allocate a dynamic array
	int* array = new int[5];
	delete[] array;

	//template <typename T> T* array2 = new T[5]
	float* array2 = new float[5];

	// Static array 
	//int array3[10];

	// Template Specialization... Declaring typename to be used by the Template
	Array<int> a1(5); // size is 5*4 bytes.
	Array<double> a2(5); // 5*8 bytes
	Array<char> a3(5); // 5*1 byte (in Java 2 bytes)
	Array<A> a4(5); // 5*4 bytes

	a1.Set_element(1, 6);
	a1.Set_element('c', 4);// Accepts a character and implicity converts it to an int
	//A objectA;

	// It cannot implicity convert a variable to an object.
	//a4.Set_element(4, 2);

	// It cannot implicity convert a variable to an object.
	//a4.Set_element('b',0); 

						   // Same result when trying to force an 
						   //object to be converted to an int, char, string...
	//a2.Set_element(objectA, 2); 
}