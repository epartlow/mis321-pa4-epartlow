using pa4_epartlow.Interfaces;

namespace pa4_epartlow
{
    public class SwordDefense : IDefend
    {
        public void Defend()
        {
            System.Console.WriteLine("Will Turner defended himself with his sword");
        }
    }
}