//This program will take 3 user inputs as the 3 sides of a triangle, and
//determine if the sides for a valid triange

#include <iostream>
using namespace std;

int main()
    {
    //The user will be promted for 3 side inputs
    int side1,
        side2,
        side3,
        sum1_2,
        sum3;

    cout << "Please enter side 1: ";
    cin >> side1;
    cout << "Please enter side 2: ";
    cin >> side2;
    cout << "Please enter side 3: ";
    cin >> side3;

    //The program will square side1 and side2 to see if the sum is equal to side 3
    sum1_2 = (side1 * side1) + (side2 * side2);
    sum3 = side3 * side3;


    if (sum1_2 > sum3)
        cout << "Not valid because side 3 is too short. ";
    else if (sum1_2 < sum3)
        cout << "Not valid because side 3 is too long. ";
    else if (sum1_2 == sum3)
        cout << "This is a valid triange. WooHoo! ";

    }
