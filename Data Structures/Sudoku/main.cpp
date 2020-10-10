#include <iostream>
#include <stack>

using namespace std;
//-----------------------------------------------------------------------------------------//
//      This program does not run without the MASSIVE amount of help from Kenny.           //  
//      While, I understood the concepts of what I have written, putting them together     //
//      into this program could not have been done without his help.                       //
//-----------------------------------------------------------------------------------------//

// Global Variables
short int board[81];
const short int
    FILLED_IN_MASK = 0x2000,
    VALUE_MASK = 0x000f,
    VALID_MASK = 0x1ff0;
stack <short int> boardStack;

// Call Functions
short int value(short int number) {
    return number & VALUE_MASK;
}

short int validNumbers(short int number) {
    return number & VALID_MASK;
}

bool filled(short int number) {
    return number & FILLED_IN_MASK;
}

bool checkIfValid(short int checkNumber, short int number) {
    return number & (FILLED_IN_MASK >> checkNumber);
}

void markAsInvalid(short int invalidNum, short int &number) {
    number &= ~(FILLED_IN_MASK >> invalidNum); 
}

short int countValids(short int number) {
    short int 
        temp = number & VALID_MASK,
        n = 0;
    
    while(temp) {
        n++;
        temp &= temp-1;
    }
    return n;
}

void changeValue(short int changeNum, short int &number) {
    number &= ~VALUE_MASK;
    number |= changeNum;
}

void markAllValid(short int &number) {
    number |= VALID_MASK;
}

void markNotFilled(short int &number) {
    number &= ~FILLED_IN_MASK;    
}

void markFilled(short int &number){
    number |= FILLED_IN_MASK;
}

void printBoard() {
    for(int i = 0; i < 81; i++) {
        cout << value(board[i]) << " ";
        if((i+1) % 9 == 0)
            cout << endl;
    }
}

bool findBestCell() {
int 
    row = 0,
    block = 0,
    blockRow = 0,
    low = 10,
    numberOfChoices,
    iBest;
    
    for(int i = 0; i < 81; i++) {
        if (!filled(board[i]))
        markAllValid(board[i]);
    }

    for(int i = 0; i < 81; i++) {
        if (filled(board[i])) {
            //-------------Rows-----------------------------
           for (int j = row; j < row + 9; j++) {
               if (!filled(board[j])) 
               markAsInvalid(value(board[i]), (board[j]));
           } 
           //-----------------------------------------------
           
           //--------------Columns--------------------------
           for (int j = i%9; j < 81; j+=9) {
               if (!filled(board[j]))
               markAsInvalid(value(board[i]),board[j]);
           }
           //------------------------------------------------
           
           //-------------3x3 Blocks-------------------------
           for(int j = block; j < block+19; j += 9) {
               for (int z = 0; z < 3; z++) {                   
                    if(!filled(board[j+z]))
                        markAsInvalid(value(board[i]), board[j+z]);
               }
           }           
           //------------------------------------------------
           
            
        }
        if((i+1) % 27 == 0)
            blockRow += 27;

        if((i+1) % 3 == 0)
            block += 3;

        if((i+1) % 9 == 0) {
            row += 9;
            block = blockRow;
        }
    }
//cout << "test1";
    for(int i = 0; i < 81; i++) {
        if(!filled(board[i])) {
            numberOfChoices = countValids(board[i]);
            if(numberOfChoices < low) {
                low = numberOfChoices;
                iBest = i;
            }   
        }
    }
    if(low == 10)
        return false;
    
    markFilled(board[iBest]);
    boardStack.push(iBest);
    return true;
}

    

int main() {
    char inputChar;
    short int stackTop;
    bool selected = false;
    
    cout << "Input the Sudoku board: " << endl;
    for(int i = 0; i < 81; i++) {
        cin >> inputChar;
        if(inputChar == '.')
            board[i] = 0;
        else {
            board[i] = 1;
            board[i] <<= 13;
            board[i] |= (inputChar - '0');
        }
    }
    printBoard();
    cout << endl << endl << endl;
    
    findBestCell();
    //cout << "test!";
    while(true) {
        bool selected = false;
        stackTop = boardStack.top();
        for(int i = 1; i <10; i++) {
            if(checkIfValid(i, board[stackTop])) {
                changeValue(i, board[stackTop]);
                markAsInvalid(i,board[stackTop]);
                selected = true;
                break;
            }
        }   
        if(selected = false) {
            markNotFilled(board[stackTop]);
            boardStack.pop();
            if (boardStack.empty()) {
                cout << "Puzzle has no solution.  Sorry. " << endl;
                return 0;
            }
            continue;
        }    
        
        if(!findBestCell())
            break;
    }
    
    cout << "Solved: " << endl; 
    printBoard();
    
    
    
    // Testing the functions.
    
    // short int ex = 0b11000000011001; 
    // cout << value(ex) << endl;
    // cout << validNumbers(ex) << endl;
    // cout << filled(ex) << endl;
    // cout << checkIfValid(1, ex) << endl;
    // markAsInvalid(1, ex);
    // cout << checkIfValid(1,ex);
    // cout << countValids(ex);
    // changeValue(8,ex);
    // cout << value(ex);
    // markAllValid(ex);
    // cout << validNumbers(ex);
    // markFilledIn(ex);
    // markNotFilled(ex);
    // cout << filled(ex);
}
