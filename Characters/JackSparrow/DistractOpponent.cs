using PA4.Interfaces;

namespace PA4.Characters.JackSparrow
{
    public class DistractOpponent : IAttack
    {
        public void Attack()
        {
            System.Console.WriteLine("Jack Sparrow Distracts His Opponent!");
        }
    }
}