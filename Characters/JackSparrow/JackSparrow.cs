namespace PA4.Characters.JackSparrow
{
    public class JackSparrow : Character
    {
        public JackSparrow()
        {
            attackBehavior = new DistractOpponent();
        }
    }
}