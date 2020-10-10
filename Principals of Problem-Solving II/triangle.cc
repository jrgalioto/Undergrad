#include <iostream>

using namespace std;

int main()
    {
     int m;
     int n;
     int side1;
     int side2;
     int hypotenuse;
     //user input m and n
     cout << "Please enter m: ";
     cin >> m;
     cout << "Please enter n: ";
     cin >> n;

     //Program calculates and sides based on user input
     side1 = m * m - n * n;
     side2 = 2 * m * n;
     hypotenuse = m * m + n + n;

     //Program prints out the 3 sides of the triange
     cout << "Side 1 is, ";
     cout << side1;
     cout << endl;

     cout << "Side 2 is, ";
     cout << side2;
     cout << endl;

     cout << "Hypotenuse is, ";
     cout << hypotenuse;
     cout << endl;
     }
