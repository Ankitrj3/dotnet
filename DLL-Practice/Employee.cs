class Employee
{
    public string Name { get; }
    public Employee(string name) => Name = name;

    public virtual void Work()
    {
        Console.WriteLine($"{Name} is working (generic).");
    }
}

class Developer : Employee
{
    public Developer(string name) : base(name) { }

    public override void Work()
    {
        Console.WriteLine($"{Name} is writing code.");
    }
}

class Manager : Employee
{
    public Manager(string name) : base(name) { }

    public override void Work()
    {
        Console.WriteLine($"{Name} is managing the team.");
    }
}
