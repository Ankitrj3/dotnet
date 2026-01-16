public class RefAndOut
{
    public void methodRef(ref int value)
    {
        value += 10;
    }
    public void methodOut(out int value)
    {
        value = 10;
    }
}