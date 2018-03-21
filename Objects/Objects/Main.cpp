#pragma once

#include<iostream>
#include<string>
#include<cstdio>
#include<cstring>
#include<istream>

int main()
{
	std::string input1, input2;
	int a,b;
	a = -1;
	b = -1;
	while (a == -1 && b == -1 )
	{
		std::cout << "Enter your first integer" << std::endl;
		std::getline(std::cin, input1);
		if (std::stoi(input1))
		{
			a = std::stoi(input1);
			std::cout << "Your int is: " << a << std::endl;
			std::cout << "Enter your second integer" << std::endl;
			std::getline(std::cin, input2);
			if (std::stoi(input2))
			{
				b = std::stoi(input2);
				std::cout << "Your int is: " << b << std::endl;
			}
			else
			{
				std::cout << "This is not an integer" << std::endl;
			}
		}
		else
		{
			std::cout << "This is not an integer" << std::endl;
		}
	}
	system("pause");
	return 0;
};