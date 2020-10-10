#include <iostream>
#include <cstdlib>

using namespace std;

int main(int argc,char *argv[]) {
  int n,r;

  srand(time(NULL));

  n = atoi(argv[1]);

  while (n > 0) {
    r = rand();
    cout << r << endl;
    n--;
  }

  return 0;
}

