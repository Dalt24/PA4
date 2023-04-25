using PA4.Interfaces;

namespace PA4.Characters.Jack_The_Monkey
{
    public class ScreetchAtOpponent : IAttack
    {
        public void Attack()
        {
            System.Console.WriteLine("Jack The Monkey Screetches at You");
        }
    }
}