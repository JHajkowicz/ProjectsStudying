
#include "user.h"
#include <iostream>
#include "userHandling.h"
#include <windows.h>
#include <vector>
#include "Hotel.h"
using namespace std;

vector<Hotel> LoadHotels(string hotelPath);

int main()
{
	int option;
	string username, password;
	bool menu = true, usernameLoop = true;
	vector<Hotel> hotelList = LoadHotels("D:\\projekt programowanie\\HotelBookingSystem\\Debug\\HotelList.txt"); //path to where hotels are stored
	

	UserHandling userHandling("D:\\projekt programowanie\\HotelBookingSystem\\Debug\\UserInfo.txt"); //path to where users are stored

	do
	{
		cout << " Welcome to hotel reservation System" << endl
			<< "1.Register" << endl
			<< "2.Log in" << endl
			<< "3.exit" << endl;

		cin >> option;
		system("CLS");
		switch (option)
		{
		case 1:
			while (usernameLoop) // loop in case username does exist
			{
				cout << "Username: "; cin >> username;
				if (userHandling.checkIfUserExists(username) == true)
					cout << "\nThis Username is already Taken !\n";
				else
					usernameLoop = false;
			}
			cout << "\nPassword: "; cin >> password;
			userHandling.createUser(username, password);
			system("CLS");
			break;
		case 2:
			cout << "Username:"; cin >> username;
			cout << "\nPassword:"; cin >> password;

			if (userHandling.login(username, password))
			{
				menu = false;
				cout << "\nU have Logged in successfully";
				Sleep(3000); system("CLS");
			}
			break;
		case 3:
			return 1;
		}		
		
	} while (menu);

	int hotelChoice ,roomChoice , reservationCancelChoice, reservedRoomCount = 1;
		menu = true;
		do
		{
			cout << "\n1.Reserve a room\n"
				<< "2.Cancel Reservation\n"
			<< "3.List of hotels\n"; cin >> option;
			switch (option)
			{
			case 1:
				for (int i = 0; i < hotelList.size(); i++)
					cout << i + 1 << "." << hotelList[i].name << endl;
				cin >> hotelChoice;
				hotelList[hotelChoice - 1].showOpenRoomList();
				cin >> roomChoice;
				hotelList[hotelChoice - 1].roomList[roomChoice - 1].reserveRoom(username);
				cout << "\n You have reserved room " << roomChoice;
				Sleep(3000); system("CLS");
				break;
			case 2:
				reservedRoomCount = 1;
				for (int i = 0; i < hotelList.size(); i++) // to display rooms 
				{
					for (int j = 0; j < hotelList[i].roomList.size(); j++)
					{
						if (hotelList[i].roomList[j].roomOwner == username)
						{
							cout << reservedRoomCount << "." << hotelList[i].name << " ";	cout << i + 1 << "." << "capacity:" << hotelList[i].roomList[j].type;
							if (hotelList[i].roomList[j].hasBathroom == 1)	cout << " has bathroom ";
							else								cout << " has no bathroom";
							cout << " price:" << hotelList[i].roomList[j].price << endl;
							reservedRoomCount++;

						}
					}
				}
				reservedRoomCount = 1;
				cin >> reservationCancelChoice;
				for (int i = 0; i < hotelList.size(); i++) // to match the room wanted to get canceled with the room on the vector list
				{
					for (int j = 0; j < hotelList[i].roomList.size(); j++)
					{
						if (hotelList[i].roomList[j].roomOwner == username)
						{
							if (reservationCancelChoice == reservedRoomCount)
							{
								hotelList[i].roomList[j].cancelReserveRoom();
							}
							reservedRoomCount++;
						}

					}
				}
			    system("CLS");
				break;
			case 3 :
				for (int i = 0; i < hotelList.size(); i++)
				{
					cout << hotelList[i].name << endl;
				}
				Sleep(4000); system("CLS");
				break;
			}
		} while (menu);



}

vector<Hotel> LoadHotels(string hotelPath) // to load all of the 
{


	string line, temp, hotelName, hotelLocation, hotelStars, roomHasBathroom, roomIsReserved, roomPrice, roomType , roomOwner;
	
	
	fstream userFile;
	vector<Hotel>hotelList;
	vector<Room> roomList;
	userFile.open(hotelPath);


	if (userFile.is_open())
	{
		while(!userFile.eof())
		{
			getline(userFile, line);
			stringstream sLine(line);
			getline(sLine, hotelName, ',');
			getline(sLine, hotelStars, ',');
			getline(sLine, hotelLocation, ',');

			
			while (!sLine.eof()) 
			{
				getline(sLine, roomType, ',');
				getline(sLine, roomPrice, ',');
				getline(sLine, roomHasBathroom, ','); 
				getline(sLine, roomIsReserved, ',');
				getline(sLine, roomOwner, ',');
				Room room(stoi(roomType), stof(roomPrice) , stoi(roomHasBathroom) , stoi(roomIsReserved),roomOwner);
				roomList.push_back(room);
			}
			Hotel hotel(hotelName, hotelStars, hotelLocation, roomList);
			hotelList.push_back(hotel);
			
		}
	}
	return hotelList;
}
