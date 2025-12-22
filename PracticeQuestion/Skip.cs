class Skip
{
    // Continue Usage: Print numbers from 1 to 50, but skip all multiples of 3 using continue
    public void Skip3Multiple(int n)
    {
        for(int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}