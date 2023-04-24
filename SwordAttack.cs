using pa4_epartlow.Interfaces;

namespace pa4_epartlow
{
    public class SwordAttack : IAttack
    {
        public void Attack()
        {
            System.Console.WriteLine("Will Turner is attacking you with his sword!");
        }
    }
}