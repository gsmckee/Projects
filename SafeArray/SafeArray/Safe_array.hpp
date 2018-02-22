#pragma once

#include "Safe_array.hpp"

#include <iostream>
#include <string>
#include <typeinfo>
#include <algorithm>


template <typename T>
class Safe_array
{
public:
	T* m_array;
	int m_capacity;
	int m_lowBound;
	int m_upBound;
	//int m_count;
	Safe_array( int a, int b)
	{
		m_lowBound = a;
		m_upBound = b;
		Capacity();
		m_array = new T[m_capacity];
		for (int i = 0; i < m_capacity; i++)
		{
			m_array[i] = i;
			//m_count++;
			std::cout << m_array[i] << std::endl;
		}
	}
	int SetValueInt(int index)// set value at given index 
	{
		m_array[index] = index;
		return m_array[index];
	}
	double SetValueDouble(int index)
	{
		m_array[index] = (index * 0.2537985);
		return m_array[index];
	}
	float SetValueFloat(int index)
	{
		m_array[index] = (index + (index * 0.15));
		return m_array[index];
	}
	//T fillArray(Safe_array &s)
	//{
	//	T value;
	//	value = type_info(s);
	//	std::cout << value << std::endl;
	//	switch (type_info(s))
	//	{
	//	case int: for (int i = 0; i < &Capacity; i++)
	//					{
	//						s[i] = i;
	//						//m_count++;
	//						std::cout << s[i] << std::endl;
	//					}
	//	case double: for (int i = 0; i < s.Capacity; i++)
	//					{
	//						s[i] = (i + (i * 0.1))
	//						//m_count++;
	//						std::cout << s[i] << std::endl;
	//					}
	//	case float: for (int i = 0; i < s.Capacity; i++)
	//					{
	//						s[i] = (i + (i * 0.1))
	//							//m_count++;
	//							std::cout << s[i] << std::endl;
	//					}
	//	default:
	//		break;
	//	}
	//}
	
	~Safe_array(void)
	{
		delete[] m_array;
	}

	T operator[](int index)
	{
		T a;
		a = index;
		return a;
	}
	static void Unit_test(void)
	{
		Safe_array sa(-6, 8);
		T a = sa[5];
		std::cout << a << std::endl;
	}
	
private:
	Safe_array()
	{}
	T Capacity(void) 
	{
		m_capacity = (m_upBound - m_lowBound) + 1;
		return m_capacity;
	}
	
};
//Safe_array::Safe_array()
//{
//}
//
//// Overloaded constructor
//Safe_array::Safe_array(int a, int b)
//{
//	m_lowBound = a;
//	m_upBound = b;
//	Capacity();
//	m_array = new int[m_capacity];
//	for (int i = 0; i < m_capacity; i++)
//	{
//		m_array[i] = i;
//		std::cout << m_array[i] << std::endl;
//	}
//}
//
//
//Safe_array::~Safe_array()
//{
//	delete[] m_array;
//}
//
//// Find the capacity given negative/ positive integrals
//int Safe_array::Capacity()
//{
//	m_capacity = (m_upBound - m_lowBound) + 1;
//	return m_capacity;
//}
//
//// return index if accessible... perform math to find the requested array index
//int Safe_array::operator[](int index)
//{
//	int a;
//	a = index - m_lowBound;
//	return a;
//}
