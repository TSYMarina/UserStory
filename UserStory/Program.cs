using System;

namespace UserStory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Wonderful Human Being! I saw you in my crystal ball! Some things were a bit blurry though... Please answer a few questions to help me out.");
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Nice to meet you {name}! What's your favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine($"I see! Please suggest an animal.");
            var animal = Console.ReadLine();
            Console.WriteLine($"Intersting! Give me a band name that first comes to mind.");
            var bandName = Console.ReadLine();
            Console.WriteLine($"YES! Now it all became clear!");
            Console.WriteLine($"You are an interesting individual {name}! In my vision I saw you dancing to a {bandName} music with {color} {animal}. Be honest - have you done something like that? Or perhaps, this is something that it waiting to happen...");
        }
    }
}
