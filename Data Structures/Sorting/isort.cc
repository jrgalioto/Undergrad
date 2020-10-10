void insertionSort(int data[],int nItems) {
  int
    split,
    i;
  int
    tmp;

  for (split=1;split<nItems;split++) {

    // pull out item just to the right of the split
    tmp = data[split];

    // mover larger items over
    for (i=split-1;i >= 0 && data[i] <= tmp;i--)
      data[i+1] = data[i];

    // insert item previously removed into the hole
    data[i+1] = tmp;
  }
}
