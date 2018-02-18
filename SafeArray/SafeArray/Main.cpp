#pragma once

#include "Safe_array.hpp"

#include <iostream>
#include <cstring> // C support
#include <cstdio> //C support
#include <string>
#include <sstream>


int main()
{

	std::string input;
	while (input == "")
	{
		std::cout << "Enter a data type for your Array" << std::endl;
		// Grabs input up to space, no sentences.
		std::cin >> input;

		//if else to handle the inputed data type.
		if (input == "int")
		{
			Safe_array<int> sa(input, -6, 8);
		}
		else if (input == "float")
		{
			Safe_array<float> sa1(input, -1, 11);
		}
		else if (input == "double")
		{
			Safe_array<double> sa2(input, -10, 12);
		}
		/*else if (input == "string")
		{
			Safe_array<std::string> sa3("five", "twenty");
		}*/
		else
		{
			std::cout << "Please enter a valid data type..." << std::endl;
			input = "";
		}
	}
	if (input != "")
	{
		std::cout << "Your data type entered is " + input << std::endl;
	}
	/*Safe_array<int> sa(-6, 8);
	Safe_array<float> sa1(-1, 11);*/
	//Safe_array::Unit_test();
	//sa.Unit_test();
	//sa1.Unit_test();
	/*sa.operator[](5);
	sa1.operator[](1);*/

	system("pause");

	return 0;
};

