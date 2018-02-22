

#include <cstdio>
#include <iostream>
#include <stdexcept>
#include <cstring>
#include <string>
void reviewPointers(void)
{
	FILE* f = fopen("Array.txt", "r");// the r stands for "read only" 
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
		if((int)buffer[0] != 10)
		{

			counter++;
		}
	}
	fclose(f);
	printf("You have %i lines in your data file \r\n", counter);
	int* array = new int[counter];
	f = fopen("Array.txt", "r");
	// Reset counter to 0, to use as a counter for appending the array.
	counter = 0;
	while (!feof(f))
	{
		fgets(buffer, 1024, f);
		if ((int)buffer[0] != 10)
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
	for (int i = 0; i < counter; i++)
	{
		std::cout << "Current value in array = " << array[i] << std::endl;
	}
	delete[] array;
	return;
}