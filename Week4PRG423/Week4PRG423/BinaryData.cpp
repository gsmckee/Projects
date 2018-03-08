#include <cstdio>// The first 2 includes should always be used when
#include <cstring>// dealing with files.
#include <iostream>

void BinaryDataHandlingTutorial(void)
{
	FILE* f = fopen("binary.bin", "wb");
	int sample = 123;
	size_t res = fwrite(&sample, sizeof(int), 1, f);
	if (res == 1)
		std::cout << "Success " << res << std::endl;
	else
		std::cout << "Oops" << std::endl;
	fclose(f);

	// In order to read data from file, be sure to use the "rb" switch/options/
	f = fopen("binary.bin", "rb");

	int read_value = 0;
	res = fread(&read_value, sizeof(int), 1, f);
	if (res == 1)
		std::cout << "Success " << read_value << std::endl;
	else
		std::cout << "Oops " << std::endl;
	fclose(f);
}
void BinaryDataHandlingTutorial2(void)
{
	FILE* f = fopen("binary.bmp", "rb");
	char buffer[30];
	size_t res = fread(&buffer[0], sizeof(char), 30, f);
	if (res == 1)
		std::cout << "Success " << sizeof(res) << std::endl;
	else
		std::cout << "Oops" << std::endl;
	fclose(f);

	// In order to read data from file, be sure to use the "rb" switch/option/parameter
	f = fopen("binary.bmp", "rb");

	int read_value_width = 0;
	int read_value_height = 0;
	res = fread(&read_value_width, sizeof(int), 1, f);
	res = fread(&read_value_height, sizeof(int), 1, f);
	if (res == 1)
		std::cout << "Success " << read_value_width << " width - " << read_value_height << " height" << std::endl;
	else
		std::cout << "Oops " << std::endl;
	fclose(f);
}