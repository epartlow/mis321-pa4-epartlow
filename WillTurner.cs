using pa4_epartlow;

namespace pa4_epartlow
{
    public class WillTurner : Character
    {
        public WillTurner()
        {
            characterName = "Will Turner";
            attackBehavior = new SwordAttack();
            defendBehavior = new SwordDefense();
        }
    }
}