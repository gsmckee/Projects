#pragma once

class Object
{
public:
	int A, B;
	Object(int a, int b);
	~Object();
	void Add(int a, int b);
	void Sub(int a, int b);
	void Div(int a, int b);
	void Mult(int a, int b);

private:
	Object();
};

