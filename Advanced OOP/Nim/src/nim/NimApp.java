/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package nim;

import java.util.*;

/**
 *
 * @author John Sullins
 */
public class NimApp {
    
    // Main application to run command line version of game

    /**
     *
     * @param args
     * @throws negRowExcption
     * @throws NoSuchRowException
     */
    public static void main(String[] args) throws negRowExcption, NoSuchRowException {        
       
        int row = 0, sticks = 0;
        Scanner scanner = new Scanner(System.in);
        
        // Construct new game object with 3, 5, and 7 sticks
        Nimgame nim = new Nimgame(new int[]{3, 5, 7});
        
        // Keep track of whose turn it is
        int player = 1;
        
        // Draw the initial board
        draw(nim);
    
        // Loop until game object reports done
        while (!nim.isOver()) {
            
            // Print whose turn it is
            System.out.println("Player "+player+" turn.");
                        
            // Prompt player for  row and number of sticks to remove
            System.out.println("Which row to remove sticks from? ");
            System.out.print("Row 0: top, Row 1: mid, Row 2: bottom: ");

            row = scanner.nextInt();
            System.out.print("How many sticks to remove: ");
            sticks = scanner.nextInt();
            
            // Send that information to the game object
            try {
            nim.play(row, sticks);
            }
            
            catch (IllegalStickException ex) {
                System.out.println("Invlid number of sticks. Must be between 1-3. You forefit this turn. ");
            }
            
            catch (NoSuchRowException ex) {
                System.out.println("Invalid row, you forefit this turn. ");
            }
            
            catch (NotEnoughSticksException ex) {
                System.out.println("Not enough sticks. You forefit this turn. ");
            }
           
            // Change the player number to the next player
            if (player == 1) {
                player = 2;
            }
            else {
                player = 1;
            }
            
            // Check whether the game is over, and print who won.
            if (nim.isOver()) {
                System.out.println("Player "+player+" wins!");
            }
            // Otherwise, redraw the board for the next turn
            else {
                draw(nim);
            }
            
        }
        
    }
     
    // Utility function to redraw game
    private static void draw(Nimgame nim) {
        for (int row = 0; row < 3; row++) {
            String sticks = "";
            for (int j = 0; j < nim.getRow(row); j++) {
                sticks += "| ";
            }
            System.out.println(sticks);
        }
    } 
    
}