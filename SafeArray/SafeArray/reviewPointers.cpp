#include <cstdio>
#include <iostream>
#include <stdexcept>
#include <cstring>
#include <string>

#include "ConvertInfo.hpp"

void reviewPointers(void)
{	
	FILE* f = fopen("data.txt", "r");// the r stands for "read only" 
	if (f == NULL)
	{
		printf("the file could not be opened");
		return;
	}
	int counter = 0;
	char buffer[1024];
	//feof is a function that returns true if the end of the file has been reached.
	while (!feof(f)) 
	{
		fgets(buffer, 1024, f);
		int sizeLine = strlen(buffer);
		//printf("%i\r\n", buffer[0], sizeLine);
		
		if((int)buffer[0] >= 48 && (int)buffer[0] <= 57)
		{

			counter++;
		}
	}
	fclose(f);
	printf("You have %i lines in your data file \r\n", counter);
	//char* str;
	int* array = new int[counter];
	f = fopen("data.txt", "r");
	// Reset counter to 0, to use as a counter for appending the array.
	counter = 0;
	while (!feof(f))
	{
		fgets(buffer, 1024, f);

		 //Comment out if block to check ascii value.
		if ((int)buffer[0] >= 48 && (int)buffer[0] <= 57)
		{			
			std::string s(buffer);
			try
			{
				int num = std::stoi(s);// number converted from a string
				array[counter] = num;
				counter++;
			}
			catch (const std::logic_error& ia) { std::cerr << "Invalid argument" << ia.what() << std::endl; }
			
		}
	}
	fclose(f);

	

	int sum = 0;
	double avg = 0;
	for (int i = 0; i < counter; i++)
	{
		std::cout << "Current value in array = " << array[i] << std::endl;
		sum += array[i];
	}
	printf("sum = %i - average = %f\r\n", sum, (double)sum / (double)counter);
	//delete[] array;
	return;
}
char* charArray()
{
	char* buffer = new char[1024];
	FILE* f = fopen("data.txt", "r");
	f = fopen("data.txt", "r");
	while (!feof(f))
	{

		for (int i = 0; i < 1024; i++)
		{			
			buffer[i] = fgetc(f);
			//PerformConversion(buffer);
			printf("%c\r\n", buffer[i]);
		}
	}
	fclose(f);
	return buffer;
	delete[] buffer;
}
ConvertInfo PerformConversion()
{
	const char* s = charArray();
	ConvertInfo convert(s);
	return convert;
}
