/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Frogger;

/**
 *
 * @author jim
 */

public abstract class Nearby extends Character {
    protected boolean active = false;

    public Nearby(int x, int y) {
        super(x, y);
    }
    
    /**
     * checks is character is nearby
     * @param playerX x-coordinate
     * @param playerY y-coordinate
     * @return true or false
     */
    protected boolean nearby(int playerX, int playerY) {  
        
        if ((Math.abs(getX() - playerX) <= 2) && (Math.abs(getY() - playerY) <= 2)) {       
            active = true;
        }
        return active;
        
    }
}

 
 
