using pa4_epartlow.Interfaces;

namespace pa4_epartlow
{
    public class CannonDefense : IDefend
    {
        public void Defend()
        {
            System.Console.WriteLine("Davy Jones repelled your attack with a cannon!");
        }
    }
}