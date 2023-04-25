using PA4.Interfaces;

namespace PA4.Characters.DavyJones
{
    public class CannonFire : IAttack
    {
        public void Attack()
        {
            System.Console.WriteLine("Davy Jones Fires a Cannon At His Opponent!");
        }
    }
}