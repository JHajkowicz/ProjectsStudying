#include "Room.h"
Room::Room(int type, float price, bool hasBathroom, bool isReserved , string roomOwner) 
{
	this->type = type;
	this->price = price;
	this->hasBathroom = hasBathroom;
	this->isReserved = isReserved;
	this->roomOwner = roomOwner;
}


void Room::reserveRoom(string roomOwner) 
{
	this->isReserved = 1;
	this->roomOwner = roomOwner;
}



void Room::cancelReserveRoom() 
{
	this->isReserved = 0;
	this->roomOwner = "";
};