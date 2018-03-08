#include <string>
#include <cstring>


#include "ConvertInfo.hpp"

ConvertInfo::ConvertInfo()
{
	value = -1;
	convResult = false;
}

ConvertInfo::ConvertInfo(const char* s)
{
	std::string str(s);
	try
	{
		value = std::stoi(str);
		convResult = true;
	}
	catch (const std::logic_error& le)
	{
		printf("%s\r\n", le.what());
	}
}
ConvertInfo::~ConvertInfo()
{
}
