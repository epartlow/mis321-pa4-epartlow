namespace pa4_epartlow
{
    public class ElizabethSwann : Character
    {
        public ElizabethSwann()
        {
            characterName = "Elizabeth Swann";
            attackBehavior = new PistolAttack();
            defendBehavior = new PistolDefense();
        }
    }
}