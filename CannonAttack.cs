using pa4_epartlow.Interfaces;

namespace pa4_epartlow
{
    public class CannonAttack : IAttack
    {
        public void Attack()
        {
            System.Console.WriteLine("Bombs away! Davy Jones is using his cannon attack!");
        }
    }
}