using PA4.Characters.HectoryBarbossa;

namespace PA4.Characters.HectorBarbossa
{
    public class HectorBarbossa : Character
    {
        public HectorBarbossa()
        {
            attackBehavior = new GrenadeThrow();
        }
    }
}