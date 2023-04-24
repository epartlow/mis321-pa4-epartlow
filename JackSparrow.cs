using pa4_epartlow;

namespace pa4_epartlow
{
    public class JackSparrow : Character
    {
        public JackSparrow()
        {
            characterName = "Jack Sparrow";
            attackBehavior = new DistractAttack();
            defendBehavior = new DistractDefense();
        }
    }
}