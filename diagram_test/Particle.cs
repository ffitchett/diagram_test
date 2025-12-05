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
        protected Image image;
        
        //constructor
        public Particle(int x, int y, int width, int height, Image image)
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
        public Image getImage() {return image;}


    }
}
