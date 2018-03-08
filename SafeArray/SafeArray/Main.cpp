#pragma once

#include "Safe_array.hpp"
//#include "reviewPointers.cpp"

#include <iostream>
#include <cstring> // C support
#include <cstdio> //C support
#include <string>
#include <sstream>

void reviewPointers(void);

int main()
{
	//std::string input;
	//while (input == "")
	//{
	//	std::cout << "Enter a data type for your Array" << std::endl;
	//	// Grabs input up to space, no sentences.
	//	std::cin >> input;

	//	//if else to handle the inputed data type.
	//	if (input == "int")
	//	{
	//		Safe_array<int> sa(-6, 8);
	//		std::cout << sa.SetValueInt(5) << std::endl;
	//		std::cout << &sa << std::endl;
	//		std::cout << sa[0] << std::endl;
	//		//sa.fillArray(sa);
	//	}
	//	else if (input == "float")
	//	{
	//		Safe_array<float> sa1(-1, 11);
	//		std::cout << sa1.SetValueFloat(5) << std::endl;
	//	}
	//	else if (input == "double")
	//	{
	//		Safe_array<double> sa2(-10, 12);
	//		std::cout << sa2.SetValueDouble(5) << std::endl;
	//	}
	//	/*else if (input == "string")
	//	{
	//		Safe_array<std::string> sa3("five", "twenty");
	//	}*/
	//	else
	//	{
	//		std::cout << "Please enter a valid data type..." << std::endl;
	//		input = "";
	//	}
	//}
	//if (input != "")
	//{
	//	std::cout << "Your data type entered is " + input << std::endl;
	//}
	reviewPointers();
	//PerformConversion();
	/*system("pause");*/
	
	return 0;
};

