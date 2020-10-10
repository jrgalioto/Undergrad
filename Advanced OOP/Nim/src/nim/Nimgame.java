/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package nim;

/**
 *
 * @author jim galioto
 */


// Constructor
public class Nimgame {
    
    int[] Rows;
    
    // This constructor should create a new game with the initial number of 
    // sticks in each row set to the corresponding elements of initialSticks. 

    /**
     *
     * @param initialSticks
     */
    
    public Nimgame(int[] initialSticks) { 
        
        // for(int i = 0; i < initialSticks.length; i++) {
        //    if (initialSticks[i] < 0) {
        //        throw new negRowExcption();
        //    }

        //   if (initialSticks.length == 0); 
        //       throw new EmptyArrayException();

        // }
    
    Rows = initialSticks;

    }
    /**
     * This method passes the row number to the array and returns the value at that index. 
     * @param r is the row index 0-2 in the array Rows.
     * @return the value of the array at that index.
     * @throws NoSuchRowException if the row index is out of the range, an exception is thrown.
     */
    
    // This inspector method returns the current number of sticks in row r. 
    public int getRow(int r) throws NoSuchRowException {
        if(r < 0 || r > 2) 
            throw new NoSuchRowException();
        
        return Rows[r];
    }
    
    /**
     * This method returns the number of rows. My only use for this method has been for looping.  
     * @return the number of rows.
     */
    
    public int getNumberOfRows() {
        return Rows.length;
    
    }
    
    /**
     * This method removes the sticks from the rows as selected by the player
     * @param r row of array
     * @param s sticks in row to be removed
     * @throws NoSuchRowException   if the player selects a row other than 0-2.
     * @throws IllegalStickException if the player ties to remove 0 or more than 3 sticks in one move.
     * @throws NotEnoughSticksException if the player tries to remove more sticks from a row than exists in that row.
     */
    
    // This modifier method should remove s sticks from row r. 
    public void play(int r, int s) throws NoSuchRowException, IllegalStickException, NotEnoughSticksException {
        if(r < 0 || r > 2) 
            throw new NoSuchRowException();
        
        if(s > 3 || s < 1)
            throw new IllegalStickException();
        
        if(s > getRow(r))
            throw new NotEnoughSticksException(); 
        
        for(int i = 0; i < Rows.length; i++) {
            if (i == r)
                Rows[i]-= s;
        }
                
    }
    
    /**
     * this method checks to see if there are sticks to remove after a play has been performed.
     * if there are, returns false. if there are not, returns true.
     * @return 
     */
    
    // This inspector returns true if there are no sticks left in any row, false otherwise.
    public boolean isOver() {
        int Sticks = 0;
        for(int i = 0; i < Rows.length; i++ ) {
            Sticks += Rows[i];
        }
        
        if (Sticks == 0) {
            return true;
        }
        else {
            return false;
        }
    }
    
    /**
     * this method is for debugging.
     * @return returns in a string the number of sticks present in each of the 3 rows.
     */
    // This should return the “state” of the object (that is, the number of sticks in each row) as a string.
    public String toString() {
        
        return "Row 1: " + getRow(0) + " Row 2: " + getRow(1) + " Row 3: " + getRow(2);
    }
    /**
     * @param args the command line arguments
     */
    
    // infile testing of methods done in addition to junit testing.
    public static void main(String[] args) {
        // TODO code application logic here
        Nimgame nim = new Nimgame(new int[]{3, 5, 7});  
        System.out.println("Is game over? "+nim.isOver());
        System.out.println(nim.toString());
        System.out.println("Number of rows: "+nim.getNumberOfRows());
        System.out.println("Sticks in row 2: "+nim.getRow(1));
        
    }
    
}
