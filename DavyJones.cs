namespace pa4_epartlow
{
    public class DavyJones : Character
    {
        public DavyJones()
        {
            characterName = "Davy Jones";
            attackBehavior = new CannonAttack();
            defendBehavior = new CannonDefense();
        }
    }
}