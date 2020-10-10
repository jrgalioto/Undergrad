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
public abstract class Character {
    
    
    protected int 
            characterX, characterY;
    protected String marker;
    
    /**
     * constructor.
     * @param characterX character's x-coordinate
     * @param characterY character's y-coordinate
     */
    
    // all derived classes will call this constructor and add the neccessery marker
    public Character(int characterX, int characterY) {
       setX(characterX);
       setY(characterY);
       
    }
    
    protected void setMarker(String marker) {
        this.marker = marker;
    }
    
    protected void setX(int characterX) {
        this.characterX = characterX;
        
    }
    
    protected void setY(int characterY) {
        this.characterY = characterY;
       
    }
    
    public int getX() {
        return characterX;
        
    }
    
    public int getY() {
        return characterY;
        
    }
    
    public String getMarker() {
        return marker;
        
    }
    
    abstract boolean isVisible();
    
    abstract void act(int playerX, int playerY);
   
}

