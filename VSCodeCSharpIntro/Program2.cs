using System;

namespace C_Sharp_Project // Namespace is a collection of classes
{
    class Rectangle2
    {
        public double length2;
        public double width2;

        public int helloWorld1(int width2, int length2)
        {
            return width2* length2;
        }
        public void setWidth(int w){
            width2 = w; // updates the class variable width value
        }
        public void setLength(int l){
            length2 = l; // updates the class variable length value
        }
    }
}
