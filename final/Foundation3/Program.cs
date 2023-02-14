using System;
namespace MethodOverloading
{
    class Program
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(float x, float y, float z)
        {
            Console.WriteLine(x + y+z);
        }
        public void Add(string s1, string s2, string s3)
        {
            Console.WriteLine(s1 + " " + s2+""+s3);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Add(15, 30, 45);
            obj.Add(20.5f, 30.5f,40.5f);
            obj.Add("computer", "bag","phone");
            Console.ReadKey();
        }
    }
}