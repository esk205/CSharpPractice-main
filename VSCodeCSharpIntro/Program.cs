using System;

namespace C_Sharp_Project // Namespace is a collection of classes
{
    class Rectangle // this is a class declaration
    {

        public double length;
        public double width;

        public int helloWorld1(int width, int length)
        {
            return width* length;
        }
        public void setWidth(int w){
            width = w; // updates the class variable width value
        }
        public void setLength(int l){
            length = l; // updates the class variable length value
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            int area =0;
            Console.WriteLine("Hello World!");
            area = r.helloWorld1(5, 5);
            r.setLength(3);
            r.setWidth(3);
            Console.WriteLine("The area is " + area);
            Console.WriteLine(r.width);
            //Console.ReadKey();
        }
    }
}
