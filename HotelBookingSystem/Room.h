#pragma once
#include <iostream>
#include "Hotel.h"
using namespace std;
class Room
{
private:
	
public:
	string roomOwner;
	int type; // capacity
	float price;
	bool hasBathroom;
	bool isReserved;
	Room(int type , float price , bool hasBathroom , bool isReserved , string roomOwner);
	void reserveRoom(string roomOwner);
	void cancelReserveRoom();
};

