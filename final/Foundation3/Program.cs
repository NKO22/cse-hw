using System;
namespace InheritanceDemo
{
    public class Program
    {
        static void Main()
        {
            // Creating object of Child class and
            // invoke the methods of Parent and Child classes
            Cuboid obj =  new Cuboid(2, 6);
            Console.WriteLine($"Volume is : {obj.Volume()}");
            Console.WriteLine($"Area is : {obj.Area()}");
            Console.WriteLine($"Perimeter is : {obj.Perimeter()}");
            Console.ReadKey();
        }
    }
    //Parent class
    public class Square
    {
        public int side;
        
        public int Area()
        {
            return side * side;
        }
        public int Perimeter()
        {
            return 2 * side;
        }
    }
    
    //Child Class
    class Cuboid : Square
    {
        public int height;
        public Cuboid(int s, int h)
        {
            side = s;
            height = h;
        }
        public int Volume()
        {
            return side * side * height;
        }
    }
}