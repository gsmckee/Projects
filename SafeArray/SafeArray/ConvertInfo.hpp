#pragma once

class ConvertInfo
{
public:
	bool convResult = false;
	int value;
	ConvertInfo(const char* s);
	~ConvertInfo();
private:
	ConvertInfo();
};

