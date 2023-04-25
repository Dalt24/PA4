using PA4.Characters;
using PA4.Characters.DavyJones;
using PA4.Characters.HectorBarbossa;
using PA4.Characters.Jack_The_Monkey;
using PA4.Characters.JackSparrow;
using PA4.Characters.WillTurner;

namespace PA4.UserFunctionality
{
    public class Factory
    {
        public Character GetPlayer()
        {
            User user = new User();
            Character player = new Character();
            System.Console.WriteLine("Welcome Player, Please Enter Your Name");
            string? playerName = Console.ReadLine();

            int charNumber = user.GetCharacter();

            if (charNumber == 1) player = new DavyJones() { name = playerName, characterName = "Davy Jones" };
            else if (charNumber == 2) player = new JackSparrow() { name = playerName, characterName = "Jack Sparrow" };
            else if (charNumber == 3) player = new WillTurner() { name = playerName, characterName = "Will Turner" };
            else if (charNumber == 4) player = new JackMonkey() { name = playerName, characterName = "Jack The Monkey" };
            else if (charNumber == 5) player = new HectorBarbossa() { name = playerName, characterName = "Hector Barbossa" };

            return player;
        }
    }
}