//This program is written by James Galioto and should calculate a monthly loan payment based on the amount of the loan, the APR, and the term length of the loan

#include <iostream>
#include <cmath>

using namespace std;

main()

    {
     float  Value, Rate, Pint, Months, Factor, Payment, Function, New_Balance;
    cout << "!!!!! Please allow me to assist you in calculating payment !!!!!" << endl << endl;

    //Firth the user will be prompted for the loan information
    cout << "Please enter the amount of your loan: ";
    cin >> Value;
    cout << "Thank you!" << endl << endl << "Please enter your interest rate: ";
    cin >> Rate;
    cout << "Thank you!" << endl << endl << "Please enter the term length of your loan in months: ";
    cin >> Months;
    cout <<"Thank you!" << endl << endl;

    //The interest rate must must be converted to decimal and distributed equally along the term of the loan
    Pint = (Rate / Months) / 100;
    //Function must be defined
    Function = pow((1 + Pint), Months);
    //Using this information, the monthly payment can now be calculated
    Payment = (Pint * Value * Function) / (Function - 1);
    cout << "Your monthly payment is: $" << Payment << endl;
    }
