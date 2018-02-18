#include "Polynomial.hpp"
#include <cstdio>
#include <iostream>
#include <cstring>


Polynomial::
Polynomial(void)
{}
Polynomial::
Polynomial(std::vector<double>& p)
{
	m_coefficients = p;
}
Polynomial:: ~Polynomial(void)
{
	m_coefficients.clear();
}
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
Polynomial Polynomial::Derive(void)
{
	size_t n = m_coefficients.size();
	size_t highestpower = n;
	std::vector<double> deriv_coefs;
	for (int i = 0; i < n; i++)
	{
		double term_deriv = (highestpower - i)*m_coefficients[i];
		deriv_coefs.push_back(term_deriv);
	}
	return Polynomial(deriv_coefs);
}
void Polynomial::Display(void)
{
	for (int i = 0; i < m_coefficients.size(); i++)
	{
		std::cout << m_coefficients[i] << " ";

		std::cout << std::endl;
	}
}
Polynomial Polynomial::operator~()
{
	return Derive();
}

