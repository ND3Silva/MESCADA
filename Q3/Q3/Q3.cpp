// Q2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
string name;

int main()
{
    cout << "What is your name?: ";
    cin >> name;

    if ((name == "Bob")|| name =="Alice") {
        cout << "Hello " << name << "!\n";
    }
   
    return 0;
}