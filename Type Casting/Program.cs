﻿static void Print(string str) => Console.WriteLine(str);

//compiler does it for you
//implicit casting

int num = 2345;
long longNum = num;
Print(num + " " + longNum);

// explicit casting
double doubleNum = 323.32;
int castedNum = (int)doubleNum;


// Advance 
string data = "124234324";
int result = 0;
if (int.TryParse(data, out result)) // pass by reference 
    Print(result+"\t passed");
else 
    Print(result + "\t failed");