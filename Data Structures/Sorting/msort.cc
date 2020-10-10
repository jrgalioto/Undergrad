void mergeSort(int data[],int aux[],int low,int high) {
  int
    mid,L,R,k;

  if (low < high) {
    mid = (low + high) / 2;

    mergeSort(data,aux,low,mid);
    mergeSort(data,aux,mid+1,high);

    L = k = low;
    R = mid + 1;

    while (L <= mid && R <= high)
      if (data[R] < data[L])
        aux[k++] = data[R++];
      else
        aux[k++] = data[L++];

    while (L <= mid)
      aux[k++] = data[L++];

    while (R <= high)
      aux[k++] = data[R++];

    for (k=low;k<=high;k++)
      data[k] = aux[k];
  }
}

void sort(int data[],int nItems) {
  int *aux;

  aux = new int[nItems];

  mergeSort(data,aux,0,nItems-1);

  delete[] aux;
}

