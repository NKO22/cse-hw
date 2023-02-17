using System;
namespace MethodOverloading
{
    class Program
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
        public void Add(string s1, string s2)
        {
            Console.WriteLine(s1 + " " + s2);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Add(100, 200);
            obj.Add(100.5f, 30.5f);
            obj.Add("Bobokoli", "Unikin");
            Console.ReadKey();
        }
    }
}

 