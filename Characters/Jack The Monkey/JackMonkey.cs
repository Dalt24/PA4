namespace PA4.Characters.Jack_The_Monkey
{
    public class JackMonkey : Character
    {
        public JackMonkey()
        {
            attackBehavior = new ScreetchAtOpponent();
        }
    }
}