namespace PA4.Characters.DavyJones
{
    public class DavyJones : Character
    {
        public DavyJones()
        {
            attackBehavior = new CannonFire();
        }
    }
}