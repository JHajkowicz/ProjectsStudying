#include "Hotel.h"
Hotel::Hotel(string name, string stars, string location, vector<Room> roomList) 
{
	this->name = name;
	this->stars = stars;
	this->location = location;
	this->roomList = roomList;
}

void Hotel::showOpenRoomList() 
{
	for (int i = 0; i < roomList.size() ; i++)
	{
		if (roomList[i].isReserved == false)
			cout << i + 1 << "."<< "capacity:" << roomList[i].type;
		if (roomList[i].hasBathroom == 1)	cout << " has bathroom ";
		else								cout << " has no bathroom";		
		cout<<" price:"<<roomList[i].price<<endl;
	}
};