public class Entrepreneur : Character{
    public Entrepreneur(string name) : base (name)
    {
    }

    public override void Attack(){
        Console.WriteLine($"{_name} throws stack of cash!");
    }
}