#include <iostream>
#include <string>
#include <simpleStack.h>
#include <exceptions.h>

using namespace std;

int main(void) {
  string
    s;
  Stack
    myStack;

  cin >> s;

  for (int i=0;i<s.length();i++)
    if (s[i] == '(')
      myStack.push('(');
    else if (s[i] == ')')
      try {
        myStack.pop();
      } catch (ContainerEmptyException e) {
        cout << "Unbalanced )" << endl;
        return 1;
      }
    else
      cout << "blah" << endl;

  if (myStack.isEmpty())
    cout << "Balanced" << endl;
  else
    cout << "Unbalanced (" << endl;

  return 0;
}
