class GuessingNumber
{
    public void GuessNum()
    {
    try{
        int secret = 7;
        int i = 1;
        int num = 0;
        do
        {
            Console.WriteLine("Enter the number");
            string? input = Console.ReadLine();
            num = int.Parse(input);
            i++;

        }while(num != secret);
        Console.WriteLine($"YOU Win! your attemps was {i}");
    }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}