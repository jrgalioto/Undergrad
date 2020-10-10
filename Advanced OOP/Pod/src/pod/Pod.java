/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pod;

import java.util.*;

/**
 * How we will manipulate the pod and player around the board.
 * @author jim
 */


public class Pod {
    
    /**
     * These are the variables that I will use to manipulate the pod and player.
     * @param x pod location in relation to the x-axis.
     * @param y pod location in relation to the y-axis.
     * @param direction directional movements that the player can make.
     * @param width the size width of the board
     * @param height the size height of the board 
     * 
     */
    
    //Constructor
    public Pod(int x, int y, String direction, int width, int height) {
       podX = x;                        
       podY = y;                        
       podDirections = direction;       //string array ["north", "south", "east", "west"] for pods to move    
       boardWidth = width;              //set to 15
       boardHeight = height;            //set to 9
       caught = false;                  //by default, no pods have been caught
    }
    
    public int getX() {                          
        return podX;
    }
    
    public int getY() {                           
        return podY;
    }
        
    public boolean isCaught() {                   
        return caught;                   //called to check if pod has been caught. default to false.
    }
    
    
//Debugging Inspector
    public String toString() {          
        return " podX: " +podX+ " podY: " +podY+ " podDirections: " +podDirections+ " boardHeight: " +boardHeight+ 
               " boardWidth: " +boardWidth+ "caught: " +caught;
    }
    
    /**
     * This method determines where the player is. 
     */
    //Pod Move Method
    public void move() {  
        bounce();                               //if the pod tries to move out of bounds, this function will return them
        
        if(podDirections == "north") {          //moves the pod north
            podY -=1;
        }
        else if(podDirections == "south") {     //moves the pod south
            podY +=1;
        }
        else if(podDirections == "east") {      //moves the pod east
            podX += 1;
        }
        else if(podDirections == "west") {      //moves the pod west
            podX -= 1;
        }
    }
    
    /**
     * This generates a random number.  If the number selected is a 3, the following method will take place.
     */
    //Random Direction Changes
    public void randomChange() {
        Random rand = new Random();
        int n = rand.nextInt(4);                //draws a random number between 0-4 
        if (n == 3) {                           //if drawn number is 3, the pod will move in a mirrored direction. 
            if(podDirections == "north") {      
            podDirections = "south";
        }
        else if(podDirections == "south") {
            podDirections = "north";
        }
        else if(podDirections == "east") {
            podDirections = "west";
        }
        else if(podDirections == "west") {
            podDirections = "east";
        }
        }
        
    }
    /**
     * Using the x/y coordinates of the player and pods, we will determine of a pod has been caught.
     * @param x the x-coordinate of the player
     * @param y the y-coordinate of the player
     */
    //Determining Whether the Pod has been Caught
    public void playerAt(int x, int y) {           
        if (podX == x && podY == y) {               
        caught = true;                             
        }   
    /**
     * Bounce occurs when the pod or player reaches the boundary of the board.
     * if a bounce occurs, the mover will be reverse its direction.
     */    
    }
    public void bounce() {
        if (podY == 0 && podDirections == "north") {
            podY = 2;
        }
        else if (podY == 8 && podDirections == "south") {
            podY = 6;
        }
        else if (podX == 0 && podDirections == "west") {
            podX = 2;
        }
        else if (podX == 14 && podDirections == "east") {
            podX = 12;
        }
    }
    
    //Private = Variables
    private int podX;
    private int podY;
    private String podDirections = new String(); 
    private int boardHeight;
    private int boardWidth;
    private boolean caught;
}
