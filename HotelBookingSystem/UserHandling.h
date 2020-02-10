#pragma once
#include <fstream>
#include<iostream>
#include <string>
#include<sstream>
using namespace std;
class UserHandling // class takes care of all the user login interaction
{
private:
	string path = "";



public:
	UserHandling(string path); // path = the path to the text file of where the users are saved
	bool login(string user , string pass); 
	void createUser(string user , string pass);
	bool checkIfUserExists(string user);	
};

