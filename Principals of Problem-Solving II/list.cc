//This program is written by Jim Galioto
#include <iostream>

using namespace std;

void reverseArray (char array[], int size);
void originalArray (char array[], int size);
void bubbleSort(char arr[], int n);

main ()
{
   int array_size, i;
   char myarray[array_size];

   //program will prompt user for length of array
   cout << "how many letters in the list? ";
   cin >> array_size ;

   //based on the user's input, the program will no ask for the appropriate number of inut character
   for (int i = 0; i < array_size; i++)
   {
       cout << "please enter a letter to add to the list ";
       cin >> myarray[i];
   }

   cout << "LIST in reverse order: " << endl;
   reverseArray (myarray, array_size);
   cout << "LIST in original order: " << endl;
   originalArray (myarray, array_size);
   cout << "LIST sorted: " << endl;
   bubbleSort(myarray, array_size);
   //originalArray (myarray, array_size);
   return 0;
}

void reverseArray (char array[], int size)
{
 for (int i = size-1; i>=0; i--)
   {
    cout << array[i] << endl;
   }
}

void originalArray (char array[], int size)
{
   for (int i = 0; i < size; i++)
   {
      cout << array[i] << endl;
   }
}

void bubbleSort(char array[], int size)
{
   {
      for (int i = 0; i < size; i++)
      {
          for (int j = 0; j < size; j++)
         {
                     // cout << "fuck" << endl;
            int temp;
            if(array[i] < array[j])
            {
               temp = array[i];
               array[i] = array[j];
               array[j] = temp;
            }

         }
cout << array[i] << endl;
      }
   }
}
