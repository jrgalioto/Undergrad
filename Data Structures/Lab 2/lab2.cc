#include <iostream>
#include "fraction.h"

using namespace std;

int main(void) {
	Fraction a,b,c;

	cout << "Enter a fraction ";
	cin >> a;

	cout << "Enter a second fraction ";
	cin >> b;

cout << a << endl;

	c = a+b;

	cout << "The sum is " << c << endl;

	return 0;
}
