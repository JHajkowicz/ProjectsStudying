#pragma once
#include <iostream>
#include "Room.h"
#include <vector>
class Room;
using namespace std;
class Hotel
{
private:
	string stars, location ;

	
public:
	vector<Room> roomList; //to store rooms that are in a hotel
	string name;
	Hotel(string name , string stars , string location , vector<Room> roomList);
	void showOpenRoomList();// to display all the rooms that are  not taken
};

