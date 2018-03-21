#include "Object.hpp"



Object::Object()
{
}

Object::Object(int a, int b)
{
	A = a;
	B = b;
}

void Object::Add(int a, int b)
{
	A = a + b;
}

void Object::Sub(int a, int b)
{
	if (a <= b)
	{
		B = b - a;
	}
	else
		B = a - b;
}

void Object::Div(int a, int b)
{
	if (a <= b)
	{
		A = b / a;
	}
	else
		A = a / b;
}

void Object::Mult(int a, int b)
{
	B = a * b;
}

Object::~Object()
{
}
