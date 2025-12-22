namespace Oops
{
    class MethodOverriding
    {
        public virtual string implementation()
        {
            return "I m the base class";
        }
    }
    class Der : MethodOverriding
    {
        public override string implementation()
        {
            return "I m the derived class";
        }
    }
}