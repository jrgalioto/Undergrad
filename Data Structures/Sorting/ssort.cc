int findMax(int data[],int n) {
  int
    i,
    guess=0;

  for (i=1;i<n;i++)
    if (data[i] > data[guess])
      guess = i;

  return guess;
}

void swap(int &a,int &b) {
  int
    tmp;

  tmp = a;
  a = b;
  b = tmp;

  /* if you have integer data, this also works...

  a ^= b;
  b ^= a;
  a ^= b;

  */
}

void ssort(int data[],int nItems) {
  int
    split,
    m;

  for (split=nItems-1;split > 0;split--) {
    m = findMax(data,split+1);

    swap(data[split],data[m]);
  }
}
