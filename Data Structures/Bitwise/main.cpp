#include <iostream>

using namespace std;

void showBits(unsigned int n) {
    for (int i = 31; i >= 0; i--)
        if (n & (1 << i))
            cout << "1";
        else
            cout << "0";
    
    cout << endl;
}

int countBits(unsigned int n)   {
    int
    count = 0;
    
    while (n !=0) {
        count++;
        n &= n -1;    
    }
    return count;
}

int main()  {
    unsigned int
    a,b,c,n;
    
    cout << "Enter Two Nonnegative Integers: ";
    cin >> a >> b;
    cout << endl;
    
    //------------------//
    //my code goes here //
    //------------------//
    
    cout << "Value of a: "; 
    showBits(a);                //debug a value
    cout << "Value of b: "; 
    showBits(b);                //debug b value
    cout << endl;
    
    //cout << "a & b: ";
    //showBits(c = a&b);                //and
    //cout << "a or b: ";       
    //showBits(c = a|b);                //or
    //cout << "a not b: ";
    //showBits(c = ~a);                 //not
    //cout << "a Exclusive OR: :";
    //showBits(c = a^b);                //exclusive or
    //cout << endl;
    
    //cout << "How many bits to shift a? ";
    //cin >> n;
    //showBits(a << n);     //shift n bits left 
    //showBits(a >> n);     //shift n bits right
    //cout << endl;
    
    cout << countBits(a);
    
    return 0;
}
