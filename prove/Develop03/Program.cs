using System;

class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("Enter the book reference of the scripture you want to store (e.g: Mark or Proverbs):");
        string bookreferenceInput = Console.ReadLine();

        Console.WriteLine("Enter the chapter reference of the scripture you want to store (e.g: 1 or 4):");
        string referenceInput = Console.ReadLine();
        int chapterreferenceInput = int.Parse(referenceInput);

        Console.WriteLine("Enter the verse reference of the scripture you want to store (e.g: 2 or 2-6):");
        string versereferenceInput = Console.ReadLine();

        Console.WriteLine("Enter the text of the scripture:");
        string textInput = Console.ReadLine();

        List<Word> words = textInput.Split(' ').Select(x => new Word(x)).ToList();

        Reference reference = new Reference(bookreferenceInput, chapterreferenceInput, versereferenceInput);
        Scripture scripture = new Scripture(reference, words);

        do
        {

            Console.Clear();
            scripture.Display();
            Console.WriteLine("Press enter to hide another word or type 'quit' to stop:");
            string userInput = Console.ReadLine();

            int wordsLeft = scripture.CountWords();
            if (wordsLeft >= 3)
            {
                scripture.HideWords(3);
            }
            else
            {
                scripture.HideWords(1);
            }

            if (userInput.ToLower() == "quit")
            {
                break;
            }
        } while (!scripture.IsFullyHidden());
        
        Console.Clear();
        scripture.Display();
        Console.WriteLine("");

        Console.WriteLine("Thank you and See you next time!");
    }
}