using pa4_epartlow.Interfaces;

namespace pa4_epartlow
{
    public class PistolAttack : IAttack
    {
        public void Attack()
        {
            System.Console.WriteLine("Elizabeth Swann is attacking you with her pistol!");
        }
    }
}