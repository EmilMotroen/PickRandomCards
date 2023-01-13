using PickRandomCards;

class PickRandomCard
{
    public static void Main()
    {
        Console.Write("Enter the number of cards to pick: ");
        string line = Console.ReadLine();
        if (int.TryParse(line, out int numberOfCards))
        {
            foreach (string card in CardPicker.PickSomeCards(numberOfCards))
            {
                Console.WriteLine(card);
            }
        } 
        else
        {
            Console.WriteLine("Could not convert input");
        }
    }
}