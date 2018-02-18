#include "Polynomial.hpp"
#include <iostream>
#include <vector>
#include <cstring>

int main()
{

	std::vector<double> coef;
	coef.push_back(1);
	coef.push_back(2);
	coef.push_back(0);
	coef.push_back(6);
	//std::cout << ("Enter your coefficients")<< std::endl;
	Polynomial p(coef);
	Polynomial p_prime = ~p;
	p_prime.Display();
	system("pause");
	return 0;
}