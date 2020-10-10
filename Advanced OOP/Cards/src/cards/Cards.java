
package cards;

import java.util.*;

public class Cards {

    public static void main(String[] args) {
     int count = 0;
     int index;                                                 // index will be used ranomly to draw cards
     Scanner input = new Scanner(System.in);
     String guess;
     
     String[] hand = new String[6];                             //this array is going to be the 5 cards drawn at random     
     String[] deck = new String[]{"ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "jack", "queen", "king"};
     
    
        for(int counter = 0; counter < 5; counter ++) {
            index = (int) (Math.random () * 12 + 0);            //random number = random index from deck array  
            hand[counter] = deck[index];                        //adding the drawn cards from string index into the hand 
        }
    
        System.out.print("Guess a card in my hand: ");
        
        System.out.println(hand[0]);                            //debug line
        
        guess = input.nextLine();
        
        while (count < 5)                                       //scanning through cards in hand
            if(!guess.equalsIgnoreCase(hand[count])) {          //if your guess doesn't match, look at the next cards
                count++;
            }
            else if(guess.equalsIgnoreCase(hand[count])) {      //if guess matches a card in the hand                
                System.out.println("I have at least one of those.  Here are my cards. ");
                for(index = 0; index < 5; index++)
                    System.out.print(hand[index] + ", ");       //print out the cards in hand
                    System.exit(0);                             //break while loop    
            }
            
            System.out.println("I don't have any of those.  Here are my cards: ");     //if the guessed card doesn't exist in the hand   
            
            for(index = 0; index < 5; index++)                  //this is the next action for correct/incorrect guesses
                System.out.print(hand[index] + ", ");           //print out cards in hand
                System.exit(0);                                 //the end
    }
}   

 
    

   
