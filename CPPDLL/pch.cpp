// pch.cpp: 与预编译标头对应的源文件

#include "pch.h"

// 当使用预编译的头时，需要使用此源文件，编译才能成功。
int cppAdd(int a, int b)
{
	return a + b;
}

char* cppMrg(const char* a, const char* b)
{
	int i, aLength, bLength;

	for (i = 0; a[i] != '\0'; i++);
	aLength = i;

	for (i = 0; b[i] != '\0'; i++);
	bLength = i;

	char* s = (char*)malloc(aLength + bLength + 1);

	memcpy(s, a, aLength);
	memcpy(s + aLength, b, bLength + 1);

	return s;
}
