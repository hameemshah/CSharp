using System;

class Guess {
    static void Main(string[] args)
    {
        int guess;
        int tries = 0;
        Console.WriteLine("Choose difficulty 1.Easy 2.Medium 3.Hard 4.Super Hard");
        string flag = Console.ReadLine();
        if(flag == "1")
            tries = 10;
        else if (flag == "2")
            tries = 5;
        else if (flag == "3")
            tries = 3;
        else if (flag == "4")
            tries = 1;
        else 
            Console.WriteLine("Please enter valid input.");
        do{
            if(tries == 0)
            {
                Console.WriteLine("You Lose.");
                break;
            }
            tries--;
            Console.WriteLine("Enter the guess: ");
            guess = int.Parse(Console.ReadLine());
            if(guess == 32)
            {
                Console.WriteLine("You Won!");
                break;
            }
            else if (guess < 32)
            {
                Console.WriteLine("Too Low");
            }
            else if (guess > 32)
            {
                Console.WriteLine("Too High");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }while(true);
    }
}