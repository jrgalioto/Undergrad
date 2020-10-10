/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Frogger;

import java.util.*;
/**
 *
 * @author jim
 */
public class Jumper extends Nearby {

    public Jumper(int characterX, int characterY) {
        super(characterX, characterY);
        setMarker("J");
        
    }
    
    // jumper is always visible    
    @Override
    public boolean isVisible() {
        return true;
    }
    
    /**
     * character jumps at random, between 0-8 on x-axis
     * @param playerX
     * @param playerY 
     */
    
    @Override
    public void act(int playerX, int playerY) {
        Random rand = new Random();
        int  n = rand.nextInt(9);
        if (this.nearby(playerX, playerY)) {
            setX(n);
        }
            
    }
    
}
