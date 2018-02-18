#pragma once

#include <vector>
//#ifndef POLYNOMIAL_H
//#define POLYNOMIAL_H

class Polynomial
{
private:
	Polynomial(void);
	std::vector<double> m_coefficients;
public:
	Polynomial(std::vector<double>& p);
	void Display(void);
	~Polynomial(void);
	Polynomial Derive();
	Polynomial operator~();
	

};

//#endif // !1


