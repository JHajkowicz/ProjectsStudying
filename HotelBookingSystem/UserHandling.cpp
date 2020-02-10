#include "UserHandling.h"

using namespace std;

UserHandling::UserHandling(string path)
{
	this->path = path;
}

bool UserHandling::login(string user , string pass) 
{
	string line , userPass;
	fstream userFile;
	
	userFile.open(path);

	
	if (userFile.is_open())
	{
		while (!userFile.eof())
		{
			getline(userFile, line);
			stringstream sLine(line);
			getline(sLine, userPass, ',');
			if (userPass == user)
			{
				getline(sLine, userPass, ',');
				if (userPass == pass)
				{
					return true;
				}
				else
					return false;
			}
			
		}
	}
	return false;
}
bool UserHandling::checkIfUserExists(string user) 
{
	string line, userName;
	fstream userFile;

	userFile.open(path);


	if (userFile.is_open())
	{
		while (!userFile.eof())
		{
			getline(userFile, line);
			stringstream sLine(line);
			getline(sLine, userName, ',');
			if (userName == user)
			{
				return true;
			}

		}
	}
	return false;
}
void UserHandling::createUser(string user ,string pass) 
{
	string line, userName;
	fstream userFile;

	userFile.open(path, ios_base::app);
	if (userFile.is_open())
	{
		userFile << "\n" + user + "," + pass;
	}

};