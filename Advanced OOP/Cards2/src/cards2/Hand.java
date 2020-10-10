/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cards2;

/**
 *
 * @author jim
 */
public class Hand {
    /**
     * @param hand is the card class variable 
     * @param HANDSIZE how many card class indexes to create.  For our purposes, 3.
     */
    
    private final Card[] hand;                  
    public static final int HANDSIZE = 3;

public Hand() {                                                                 
    hand = new Card[HANDSIZE];                                                      //new card in hand
    for(int i = 0; i < HANDSIZE; i++) {                                             //drawn as many times as required by user to create initial hand
        hand[i] = new Card();                                                       
    }
}
public String getHand() {
/**
 * This method will return the card indexes one by one comprising the hand.
 * @param returnString this is the output to display on the game side.
 */
    
    String returnString = "";
    for(int i=0; i < HANDSIZE; i++) {                                               //shows players hand
        returnString += hand[i].getSuite() + " ";
    }
    return returnString;
}

public String changeCard() {
/**
 * This method makes it so that every card index can be changed a random with each player move.
 * @param returnString is the output to display on the game side.
 */

    String returnString = "";
    for(int i = 0; i < HANDSIZE; i++ ) {                                            //scan hand.  each card has 0-4 chance of incrimenting  up a suite.
        if(hand[i].randomChange())
            returnString += "Card " + i + " was change to "                         //if true, return change 
            + hand[i].getSuite() + "\n";
    }
    return returnString;                                                            //otherwise, state hand
}

public boolean isGameOver() {
    /**
     * This method is called before each move to determine if the player has won by comparing
     * the suites to see if they are identical. If they do not all match, the game continues.
     * @param compare the first card index of the hand is set to this variable in compare with the others in the hand.
     */
    
    String compare = hand[0].getSuite();                                            //game is over if all 3 cards are equal
    for(int i = 0; i < HANDSIZE; i++) {                                             //compare cards with card[0]
        if(!hand[i].getSuite().equals(compare))                                     
            return false;
    }
    return true;
}
public String playerChange(int i) {  
    /**
     * In this method, the player is asked which card object they would like to swap for another.
     */
    if(i > HANDSIZE)                                                                
        return "Please enter a valid card: ";
    if(i < HANDSIZE)                                                                //card[input] is replaced
        hand[i] = new Card();
    return "Card " + i + " has been change to " + hand[i].getSuite();               //player is shown new card
    }
    
}