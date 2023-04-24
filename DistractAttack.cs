using pa4_epartlow.Interfaces;

namespace pa4_epartlow
{
    public class DistractAttack : IAttack
    {
        public void Attack()
        {
            System.Console.WriteLine("Jack Sparrow made an attempt to distract you!");
        }
    }
}