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
public class Chaser extends Interceptor {

    public Chaser(int characterX, int characterY) {
        super(characterX, characterY);
        setMarker("C");
        
    }
    /**
     * 
     * @param playerX player's x-coordinate
     * @param playerY player's y-coordinate
     * @param x character's x-coordinate
     * @param y character's y-coordinate
     * @return true or false if the character and player are within 2 squares of one another
     */   
    public boolean nearby(int playerX, int playerY, int x, int y){
        return (Math.abs(getX() - playerX) <= 2) && (Math.abs(getY() - playerY) <= 2);
    }
    
    /**
     * character moves in relation to player on the x/y grid
     * @param playerX
     * @param playerY 
     */
    public void act(int playerX, int playerY) {        
        super.act(playerX, playerY);
        if(getY() < playerY)
            setY(getY() +1 );
        if(getY() > playerY)
            setY(getY() -1) ;                            
    }    
}
