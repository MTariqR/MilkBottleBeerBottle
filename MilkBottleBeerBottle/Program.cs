namespace MilkBottleBeerBottle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount = 99;
            string bottles = "bottles";
            while (amount > 0)
            {
                if (amount == 1)
                {
                    bottles = "bottle";
                    Console.WriteLine($"{amount} {bottles} of beer on the wall, {amount} {bottles}  of beer.");
                    break;
                }
                Console.WriteLine($"{amount} {bottles} of beer on the wall, {amount} {bottles}  of beer.\nTake one down, and pass it around, " +
                    $"{amount-1} {bottles} of beer on the wall.");
                amount--;
            }
        }
    }
}
