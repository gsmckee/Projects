#include "Safe_array.hpp"
#include <iostream>


// Default Constructor
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
//
//// Display the results

