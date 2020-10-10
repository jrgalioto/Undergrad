#ifndef _SIMPLESTACK_H
#define _SIMPLESTACK_H

#include <exceptions.h>

const int STACK_SIZE = 10;

union UItem {
    int iVal;
    double dVal;
};

typedef union UItem StackType;

class Stack {
 public:
  Stack(void) { count = 0; }
  ~Stack(void) { }

  void clear(void) { count = 0; }
  int size(void) { return count; }
  bool isEmpty(void) { return count == 0; }

  void push(const StackType &) throw (ContainerFullException);
  StackType pop(void) throw (ContainerEmptyException);
  StackType peek(void) throw (ContainerEmptyException);

 private:
  StackType
   data[STACK_SIZE];
  int
   count;
};

#endif
