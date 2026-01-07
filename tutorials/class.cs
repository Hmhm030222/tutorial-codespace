using System;

namespace ClassLearning
{
    class Variables
    {
        public int x;
        public int y;
        private int z;
    }

    class Program
    {
       static void Main()
        {
            Variables var = new Variables();
            var.x = 10;
            var.y = 20;
            Console.WriteLine($"X: {var.x}, Y: {var.y}");
        }
    }
}