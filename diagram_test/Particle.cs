using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagram_test
{
    public class Particle
    {
        //attributes
        protected int x;
        protected int y;
        protected int width;
        protected int height;
        protected int xspeed;
        protected int yspeed;
        protected Image image;
        
        //constructor
        public Particle(int x, int y, int width, int height, int xspeed, int yspeed, Image image)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.image = image;
        }

        //getters and setters
        public int getX(){ return x;}
        public int getY(){ return y;}
        public int getWidth() { return width;}
        public int getHeight() { return height;}
        public int getXspeed() { return xspeed;}

        public int getYspeed() { return yspeed;}
        public Image getImage() {return image;}

        // calculates the rate at which particles should move horizontally to reach a target in an amount of time
        public int FindXspeed(int targetX, int particleX, int time_ratio)
        {
            int Xdistance = targetX - particleX;
            if (Xdistance <= 0) { Xdistance = -Xdistance; }
            return (Xdistance / time_ratio);
        }

        // calculates the rate at which particles should move vertically to reach a target in an amount of time
        public int FindYspeed(int targetY, int particleY, int time_ratio)
        {
            int Ydistance = targetY - particleY;
            if (Ydistance <= 0) { Ydistance = -Ydistance; }
            return (Ydistance / time_ratio);
        }

        public void Update()
        {

        }


    }
}
