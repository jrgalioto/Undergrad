/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package nim;

import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author jim
 */
public class NimgameTest {
    
    public NimgameTest() {
    }
    
    @BeforeClass
    public static void setUpClass() {
    }
    
    @AfterClass
    public static void tearDownClass() {
    }
    
    @Before
    public void setUp() {
    }
    
    @After
    public void tearDown() {
    }

    /**
     * Test of getRow method, of class Nimgame.
     */
    @Test
    public void testGetRow() {
        System.out.println("getRow");
        int r = 0;
        Nimgame instance = new Nimgame(new int[]{3, 5, 7});
        int expResult = 3;
        int result = instance.getRow(r);
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        // fail("The test case is a prototype.");
    }

    /**
     * Test of getNumberOfRows method, of class Nimgame.
     */
    @Test
    public void testGetNumberOfRows() {
        System.out.println("getNumberOfRows");
        Nimgame instance = new Nimgame(new int[]{3, 5, 7});
        int expResult = 3;
        int result = instance.getNumberOfRows();
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        // fail("The test case is a prototype.");
    }

    /**
     * Test of play method, of class Nimgame.
     */
    @Test
     public void testPlay() {
        System.out.println("play");
        int r = 0;
        int s = 0;
        Nimgame instance = null;
        // TODO review the generated test code and remove the default call to fail.
        // fail("The test case is a prototype.");
     }

    /**
     * Test of isOver method, of class Nimgame.
     */
    
    @Test
    public void testIsOver() {
        System.out.println("isOver");
        Nimgame instance = new Nimgame(new int[]{3, 5, 7});
        boolean expResult = false;
        boolean result = instance.isOver();
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        // fail("The test case is a prototype.");
    }

    /**
     * Test of toString method, of class Nimgame.
     */
    @Test
    public void testToString() {
        System.out.println("toString");
        Nimgame instance = new Nimgame(new int[]{3, 5, 7});
        String expResult = "Row 1: 3 Row 2: 5 Row 3: 7";
        String result = instance.toString();
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        // fail("The test case is a prototype.");
    }

    /**
     * Test of main method, of class Nimgame.
     */
    @Test
    public void testMain() {
        System.out.println("main");
        String[] args = null;
        Nimgame.main(args);
        // TODO review the generated test code and remove the default call to fail.
        // fail("The test case is a prototype.");
    }
    
}
