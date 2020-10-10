//This Program is written by James Galioto
#include <iostream>
#include <iomanip>

using namespace std;

int n;

//prototype placeholder for function
bool isprime(int x);

int main()
{
   //get user input to initialate function
   cout << "please enter a whole number: ";
   cin >> n;
   cout << "Number" << "\t" << "Prime/ Not Prime" << "\t" << endl;

   //I need to set up a counter starting from the inut ticking down by 1
   for(int count = 0; count<n; n--)
   {
         //if the function returns as false, the number is prime
         if (isprime(n))
             cout << n << "\t" << "Prime" << endl;
         //all other scenerios are not prime
         else
             cout << n << "\t" << "Not Prime" << endl;
   }
return 0;
}

bool isprime(int x)
{
   //the input must be greater than 2 becuase of the definiton of prime
   if (n != 2)
   {
      if(n < 2 || n % 2 == 0)
      {
         return false;
      }
      //testing a prime number must begin at 2.
      //if there is a remainder, x needs to incriment up to (not) the input.
      //if x reaches the input and still have a remainder the input is prime
      //if there is no remainer, the input is not prime
      for(int x = 2; x < n; x++)
      {
         if(n % x == 0)
         {
            return false;
         }
      }
    }
}
