#include <iostream>
#include "fraction.h"

using namespace std;

int main(void) { 
	Fraction currentX;
	Fraction currentY;
	Fraction firstX;
	Fraction firstY;
	Fraction previousX;
	Fraction previousY;
	Fraction area;	
	
	cout << "enter point x: "; 
	cin >> firstX;							//initial point x for comparrison
	cout << "enter point y:	";
	cin >> firstY;							//initial point y for comparrison
	currentX = firstX;					//set current variable x = fist variable x
	currentY = firstY;					//set current variable y = first variable y

	
//-------------------------------------------------------------------------------------//
//while the current inputs are different than the first inputs, do the following loop. //
//-------------------------------------------------------------------------------------//

do {
	previousX = currentX;		//sets your previous points to the value of 
	previousY = currentY;		//your current points for comparisson
	
	cout << "enter next point x: ";
	cin >> currentX;
	cout << endl;
	cout << "enter next point y: ";
	cin >> currentY;
	
	area = area + (previousX * currentY - currentX * previousY);	//math
} while(currentX != firstX && currentY!= firstY);		//is the current point the same as your first? 

area = area/2;
cout << "The area of the sides of your polygon is: " << area << endl;
	
return 0;
}
