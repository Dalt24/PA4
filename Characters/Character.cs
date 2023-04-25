using PA4.Interfaces;

namespace PA4.Characters
{
    public class Character
    {
        public string? name { get; set; }
        public string? characterName { get; set; }
        public int maxPower { get; set; }
        public double health { get; set; } = 100;
        public int? attackStrength { get; set; }
        public int? defensivePower { get; set; }
        public IAttack? attackBehavior { get; set; }
        public Character()
        {
            Random rnd = new Random();
            maxPower = rnd.Next(1, 101);
            attackStrength = rnd.Next(1, maxPower);
            defensivePower = rnd.Next(1, maxPower);
        }

        public int AttackStrength()
        {
            Random rnd = new Random();
            int attackStrength = rnd.Next(1, maxPower);
            return attackStrength;
        }
        public int DefensePower()
        {
            Random rnd = new Random();
            int defensePower = rnd.Next(1, maxPower);
            return defensePower;
        }
    }
}