
namespace PA4.UserFunctionality
{
    public class User
    {
        public int GetCharacter()
        {
            System.Console.WriteLine($"\nPlease Select a Character. \n1. Davy Jones \n2. Jack Sparrow \n3. Will Turner \n4. Jack The Monkey \n5. Hector Barbossa");
            bool a = int.TryParse(Console.ReadLine(), out int characterName);
            while (characterName < 1 || characterName > 5 || a == false)
            {
                System.Console.WriteLine($"\nInvalid choice, Please Select a Character. \n1. Davy Jones \n2. Jack Sparrow \n3. Will Turner \n4. Jack The Monkey \n5. Hector Barbossa");
                a = int.TryParse(Console.ReadLine(), out characterName);
            }
            return characterName;
        }

        public int GetCoinFlip()
        {
            Random rnd = new Random();
            return rnd.Next(0, 2);
        }
    }
}