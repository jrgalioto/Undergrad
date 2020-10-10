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

public class Game {
    public static final String WIN_MESSAGE = "YOU WIN! ";
    public static void main(String[] args) {
       
        Hand player = new Hand();
        Scanner input = new Scanner(System.in);
        int swap;
        while(!player.isGameOver()) {
            System.out.println(player.getHand());
            System.out.println("Which Card would you like to swap? (0-2) ");
            swap = input.nextInt();
            System.out.println(player.playerChange(swap));
            System.out.println(player.changeCard());
        }
       System.out.println(WIN_MESSAGE);
    }
    
}
