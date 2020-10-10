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
public class Interceptor extends Character {

    public Interceptor(int characterX, int characterY) {
        super(characterX, characterY);
        setMarker("I");
      
    }

    @Override
    public boolean isVisible() {
        return true;
    }
    
    /**
     * character moves along the the x a-axis
     * @param playerX
     * @param playerY 
     */
    
    @Override
    public void act(int playerX, int playerY) {
        if (getX() < playerX)
            setX(getX() + 1);
        if (getX() > playerX)
            setX(getX() - 1);
    }
    
    public static void main(String[] args) {
        Character test = new Interceptor(3,1);
        test.setMarker("I");
        test.getX();
        System.out.println(test.getX());
        System.out.println(test.getY());
        System.out.println(test.getMarker());
        
        
}

}


  
    

