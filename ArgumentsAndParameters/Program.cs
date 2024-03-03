


Console.WriteLine("Enter a word");

string userInput = Console.ReadLine();

PrintAnyWord(userInput); // userInput  - argumet



static void PrintAnyWord(string anyString) // anystring - argumet - parameter

{
    anyString = anyString.ToUpper();
    for(int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}