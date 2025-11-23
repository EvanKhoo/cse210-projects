
class Program
{
    
    static void Main(string[] args)
    {
        List<Character> players = new List<Character>();

        Character bob = new Character("Bob");
        players.Add(bob);

        Magician marge = new Magician("Marge");
        players.Add(marge);

        Entrepreneur steve = new Entrepreneur("Steve");
        players.Add(steve);

        Movement mover = new Movement();

        foreach (Character character in players){
            character.Attack();
            mover.Movement();
        }
    }
}