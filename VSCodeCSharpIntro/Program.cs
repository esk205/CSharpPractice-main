using System;

namespace C_Sharp_Project // Namespace is a collection of classes
{
    class Rectangle // this is a class declaration
    {

        public double length =0;
        public double width=0;

        public int helloWorld1(int width, int length)
        {
            return width* length;
        }
        /*
        public void setWidth(int w){
            width = w; // updates the class variable width value
        }
        public void setLength(int l){
            length = l; // updates the class variable length value
        }
        */
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle r = new Rectangle();
            Rectangle2 r2 = new Rectangle2();
            double area =0, area2=0;
            Console.WriteLine("Hello World!");
            area2 = r2.helloWorld1(5, 5);
            //area = r.helloWorld1(5, 5);

            r2.setLength2(5);
            r2.setWidth2(4);

            area2 = r2.width2*r2.length2;
           // r.setLength(3);
            //r.setWidth(3);
            Console.WriteLine("The area is " + area2);
            Console.WriteLine(r2.width2);
            //Console.ReadKey();
        }
    }
}
