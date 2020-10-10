#include <iostream>

using namespace std;

int data[1000000];

void sort(int[],int);

int main(void) {
  int nItems,i;

  for (nItems=0;nItems<1000000;nItems++) {
    cin >> data[nItems];
    if (!cin)
      break;
  }

  sort(data,nItems);

  for (i=0;i<nItems;i++)
    cout << data[i] << endl;

  return 0;
}
