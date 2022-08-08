
import java.awt.Color;
/**
 *
 * @author 24477516 Cameron Smith
 */
public class SolarSystem { //this will program a basic solar system using 3DstdDraw, rotation
    public static void  main(String[] args){ //main method we use to run the code
        StdDraw3D.clearLight(); //clears the default light set at the start 
        StdDraw3D.setScale(-2000, 2000); //sets the scale of our Canvas as default is 0-1
        StdDraw3D.setBackgroundSphere("src/solarstars.jpg"); //sets our background texture 
        StdDraw3D.pointLight(0, 0, 0, Color.WHITE); //this adds light at the center of our solar system     
        double R= 18; //radius of the circle of rotation 
        double R1 = 30; //radius of the second planet circle of rotation
        double R2 = 55;  //radius of the third planet circle of rotation 
        double R3 = 85; //radius of the fourth planet circle of rotation
        double R4 = 120; //radius of the fifth planet circle of rotation
        double R5 = 175; //radius of the saturn planet circle of rotation
        double R6 = 260; //radius of the uranus planet circle of rotation 
        double R7 = 390; //radius of the neptune planet circle of rotation
        //my planet objects with texture 
        StdDraw3D.Shape sun = StdDraw3D.sphere(0, 0, 0, 9, "src/sun.jpg"); 
        StdDraw3D.Shape mecury = StdDraw3D.sphere(0, 0, 0, 3, "src/mecury.jpg");
        StdDraw3D.Shape venus= StdDraw3D.sphere(0, 0, 0, 6, "src/venus.jpg");
        StdDraw3D.Shape earth = StdDraw3D.sphere(0, 0, 0, 12, "src/earth.jpg");
        StdDraw3D.Shape mars = StdDraw3D.sphere(0, 0, 0, 15, "src/mars.jpg");
        StdDraw3D.Shape jupiter = StdDraw3D.sphere(0, 0, 0, 25, "src/jupiter.jpg");
        StdDraw3D.Shape saturn = StdDraw3D.sphere(0, 0, 0, 35, "src/saturn.jpg");
        StdDraw3D.Shape uranus = StdDraw3D.sphere(0, 0, 0, 45, "src/uranus.jpg");
        StdDraw3D.Shape neptune = StdDraw3D.sphere(0, 0, 0, 70, "src/neptune.jpg");
        
        // angle  of the sun on the circle
        double angle = 0;
        //the milliseconds per frame for the rotation of the mars 
        int time=50;
        while(true){ //creates a while true loop that will loop our rotation 
            //calulating the position
            double x = R*Math.cos(angle); //calulates the x position for our mecury
            double y = R*Math.sin(angle); //calulates the y position for our mecury
            double z=10; //sets our z position for our Mecury
        //increments the angle helps the rotation of the planets
        angle += 0.02;
        //StdDraw3D.clear(); //clears the canvas allowing for easier animation
        //planets we need to rotate around the sun the center of the system
        //Sun
        sun.setPosition(0, 0, 0); //sets the new position of the sun which is the center 
        //Mecury 
        mecury.setPosition(x, y, z);
        //venus
            double x1 = R1*Math.cos(angle); //calulates the x position for our Mars
            double y1 = R1*Math.sin(angle); //calulates the y position for our Mars
            double z1=25; //sets our z position for our venus
        venus.setPosition(x1, y1, z1); //updates the position of our planet allowing for rotation bycalulating each position in the while loop
        //Earth 
            double x2 = R2*Math.cos(angle); //calulates the x position for our Mars
            double y2 = R2*Math.sin(angle); //calulates the y position for our Mars
            double z2=30; //sets our z position for our Mars
            earth.setPosition(x2, y2, z2);//updates the position of our planet allowing for rotation bycalulating each position in the while loop
            StdDraw3D.setCamera(x2, y2, z2, 950, 950, 950);
        //Mars
            double x3 = R3*Math.cos(angle); //calulates the x position for our Mars
            double y3 = R3*Math.sin(angle); //calulates the y position for our Mars
            double z3=40; //sets our z position for our Mars
            mars.setPosition(x3, y3, z3);//updates the position of our planet allowing for rotation bycalulating each position in the while loop
        //Jupiter
            double x4 = R4*Math.cos(angle); //calulates the x position for our Mars
            double y4 = R4*Math.sin(angle); //calulates the y position for our Mars
            double z4=60; //sets our z position for our Mars
        jupiter.setPosition(x4, y4, z4);//updates the position of our planet allowing for rotation bycalulating each position in the while loop
        //Saturn 
            double x5 = R5*Math.cos(angle); //calulates the x position for our Mars
            double y5 = R5*Math.sin(angle); //calulates the y position for our Mars
            double z5=70; //sets our z position for our Mars
        saturn.setPosition(x5, y5, z5);//updates the position of our planet allowing for rotation bycalulating each position in the while loop
        //uranus
            double x6 = R6*Math.cos(angle); //calulates the x position for our Mars
            double y6 = R6*Math.sin(angle); //calulates the y position for our Mars
            double z6=80; //sets our z position for our Mars
        uranus.setPosition(x6, y6, z6);
        //neptune //thal is a little gym body melon minion :)
            double x7 = R7*Math.cos(angle); //calulates the x position for our Mars
            double y7 = R7*Math.sin(angle); //calulates the y position for our Mars
            double z7=90; //sets our z position for our Mars
        neptune.setPosition(x7, y7, z7);
        // this will enable the rotation of our objects
        StdDraw3D.show(time);
        }
    }
}
