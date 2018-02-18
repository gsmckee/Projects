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
	int m_count;
	Safe_array(std::string dtype, int a, int b) 
	{
		m_lowBound = a;
		m_upBound = b;
		Capacity();
		m_array = new T[m_capacity];
		
		if (dtype == "int")
		{
			for (int i = 0; i < m_capacity; i++)
			{
				m_array[i] = i;
				m_count++;
				std::cout << m_array[i] << std::endl;
			}
		}
		else if (dtype == "float")
		{
			for (int i = 0; i < m_capacity; i++)
			{
				m_array[i] = (i * 0.2537985);
				m_count++;
				std::cout << m_array[i] << std::endl;

			}
		}
		else if (dtype == "double")
		{
			for (int i = 0; i < m_capacity; i++)
			{
				m_array[i] = (i + (i * 0.1));
				m_count++;
				std::cout << m_array[i] << std::endl;
			}
		}
		
						
		/*else if (typeid(m_capacity) = typeid(string))
		{
			m_array[i] = i>> std::istringstream()
		}*/
		else { std::cout << "Improper data type." << std::endl; }
		std::cout << "Size of the array " << m_count << std::endl;
		
	}
	~Safe_array(void) 
	{
		delete[] m_array;
	}

	T operator[](int index) 
	{
		T a;
		a = index - m_lowBound;
		return a;
	}
	static void Unit_test(void)
	{
		Safe_array sa(-6, 8);
		T a = sa[5];
		std::cout << a<< std::endl;
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
