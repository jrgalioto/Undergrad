/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cards2;

import java.util.*;

/**
 * 
 * @author jim
 */

public class Card {
    /**
     * @param rand random int generator.
     * @param PROBABILITY int between 0-4 in the case of this class.
     * @param SUITE_TYPE int of types of cards in this class.
     * @param suite string variable set based on rand.
     */
    
    Random rand = new Random();                     
    public static final int PROBABILITY = 5;                    //probability that a card will be changed 0-4
    public static final int SUITE_TYPE = 4;                     //number of card suites 0-3
    private String suite;                                       //variable set to the type of card drawn. 
    
    public Card() {
    /**
     * This method will generate a random number.  Based on that number, a card type is assigned to the suite variable.
     */
        
    int index = rand.nextInt(SUITE_TYPE);                   
        if(index == 0)
            suite = "c";
        if(index == 1)
            suite = "d";
        if(index == 2)
            suite = "h";
        if(index == 3)
            suite = "s";
    }
    
    public String getSuite() {                      
        return suite;
        
    }
    
    public boolean randomChange() {
    /**
     * In this method, a scan through of the cards gives each one the chance to change. Based on a number drawn 
     * (0-4 in this case), if the 0 is drawn, the card will be reassigned to the next suite alphabetically.
     * c->d, d->h, h->s, s will wrap back around to c.
     */
        int randChange = rand.nextInt(PROBABILITY);             //0-4 is chosen 
        if(randChange == 0) {                                   //if 0, true and the suite of the card is changed is sequential order
            if(suite == "c")
                suite = "d";
            else if (suite == "d")
                suite = "h";
            else if (suite == "h")
                suite = "s";
            else if (suite == "s")
                suite = "c";
            return true;
        }
        else                                                    //otherwise, no change is made.
            return false;
    }
}



