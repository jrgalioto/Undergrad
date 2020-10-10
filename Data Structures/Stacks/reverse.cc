#include <iostream>
#include <simpleStack.h>

using namespace std;

int main(void) {
  int n,d;
  Stack myStack;

  cin >> n;

  while (n != 0) {
    d = n % 10;
    n = n / 10;

    myStack.push(d);
  }

  while (!myStack.isEmpty()) {
    d = myStack.pop();

    cout << d << endl;
  }

  return 0;
}
