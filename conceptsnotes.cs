
using System;
using System.Collections.Generic;

class Notes {
﻿// See https://aka.ms/new-console-template for more information
Console.Write("Hello World!");
Console.Write("This will be on the same line.");


int age = 17;
Console.WriteLine(age);

long longNumber = 15000000000L;
Console.WriteLine(longNumber);


double myDoubleNum = 5.99D;
Console.WriteLine(myDoubleNum);

float floatNumber =  5.75F;
Console.WriteLine(floatNumber);

char Letter = 'A';
Console.WriteLine(Letter);

string name = "Kai";
Console.WriteLine(name);

bool ToF = true;
Console.WriteLine(ToF);

float f1 = 35e3F;
double d1 = 12e4D;
Console.WriteLine(f1);
Console.WriteLine(d1);

Console.WriteLine("Hello, " + name);

string firstName = "Kai ";
string lastName = "T";
string fullName = firstName + lastName;
Console.WriteLine(fullName);

/*
int x = 5;
int y = 6;
Console.WriteLine(x + y);
int x = 10, y = 15, z = 20;
Console.WriteLine(x + y + z);*/


int x, y, z;
x = y = z = 50;
Console.WriteLine(x+y+z);

double myDouble = 9.75;
int myInt = (int) myDouble;

Console.WriteLine(myDouble);
Console.WriteLine(myInt);

int thisInt = 1;
double thisDouble = 2.0;
bool thisBool = true;

Console.WriteLine(Convert.ToString(thisInt));
Console.WriteLine(Convert.ToInt32(thisDouble));
Console.WriteLine(Convert.ToString(thisBool));
}