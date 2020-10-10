void bsort(int data[],int nItems) {
  int
    i,j;
  int
    tmp;

  for (i=0;i<nItems-1;i++)

    for (j=0;j<nItems-1-i;j++)

      if (data[j] > data[j+1]) {
        tmp = data[j];
        data[j] = data[j+1];
        data[j+1] = tmp;
      }
}

void bsort2(int data[],int nItems) {
  int
    j;
  int
    tmp;
  bool
    changed;

  do {

    changed = false;

    for (j=0;j<nItems-1;j++)

      if (data[j] > data[j+1]) {
        changed = true;
        tmp = data[j];
        data[j] = data[j+1];
        data[j+1] = tmp;
      }

  } while (changed);
}
