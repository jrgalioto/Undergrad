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
import org.junit.runner.RunWith;
import org.junit.runners.Suite;

/**
 *
 * @author jim
 */
@RunWith(Suite.class)
@Suite.SuiteClasses({nim.NimAppTest.class, nim.NimgameTest.class, nim.NoSuchRowExceptionTest.class, nim.NotEnoughSticksExceptionTest.class, nim.negRowExcptionTest.class, nim.IllegalStickExceptionTest.class, nim.EmptyArrayExceptionTest.class})
public class NimSuite {

    @BeforeClass
    public static void setUpClass() throws Exception {
    }

    @AfterClass
    public static void tearDownClass() throws Exception {
    }

    @Before
    public void setUp() throws Exception {
    }

    @After
    public void tearDown() throws Exception {
    }
    
}
