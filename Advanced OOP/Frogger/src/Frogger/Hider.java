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
public class Hider extends Nearby {

    public Hider(int characterX, int characterY) {
        super(characterX, characterY);
        setMarker("H");
       
    }
    
    private boolean visible = true;
    
    /**
     * if nearby, not visible 
     * @return true or false
     */
    
    @Override
    public boolean isVisible() {
        return visible;
        
    }
    /**
     * character alternates visible/invisible on alternating turns beginning when nearby is active.
     * @param playerX
     * @param playerY 
     */
    public void act(int playerX, int playerY) {
        if(super.nearby(playerX, playerY))
            visible = !visible;
    }
}    

    
   
