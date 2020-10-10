void qsortRec(int data[],int low,int high) {
  int
    i,bdy;
  int
    tmp;

  if (low < high) {
    bdy = low;

    for (i=low+1;i<=high;i++)
      if (data[i] < data[low]) {
        bdy++;
        tmp = data[bdy];
        data[bdy] = data[i];
        data[i] = tmp;
      }

    tmp = data[bdy];
    data[bdy] = data[low];
    data[low] = tmp;

    qsortRec(data,low,bdy-1);
    qsortRec(data,bdy+1,high);
  }
}

void sort(int data[],int nItems) {

  qsortRec(data,0,nItems-1);
}
