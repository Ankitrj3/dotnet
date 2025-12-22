class DiamondShape
{
    public void DrawDiamond(int n)
    {
        // upper half
        for(int i = 1; i <= n; i++)
        {
            for(int spaces = 1; spaces <= n - i; spaces++)
            {
                Console.Write(" ");
            }
            for(int star = 1; star <= 2*i - 1; star++)
            {
                Console.Write("*");
            }

            Console.WriteLine("");
        }

        // Lower Half

        for(int i=n-1; i>=1; i--)
        {
            for(int spaces=1; spaces<=n-i; spaces++)
            {
                Console.Write(" ");
            }
            for(int star=1; star<=2*i-1; star++)
            {
                Console.Write("*");
            }

            Console.WriteLine("");
        }
    }
}