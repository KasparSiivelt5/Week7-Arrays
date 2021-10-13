using System;

namespace Week7arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm palub kasutajal valida ,mida ta hommikusöögiks sööb

            string[] food = { "võileib juustuga", "banaan", "peekon", "muna" };

            food[3] = "viiner";
            food [1] = "keefir"
            Console.WriteLine("menüüs");

            for (int i = 0; i < food.Length; i++)
            {
             Console.WriteLine(food {i});
            }
             Console.WriteLine("vali toit (sisesta numbri - 5:");
        }    int userchoice = Convert.ToInt32(Console.ReadLine()) - 1;

             
    }
}
