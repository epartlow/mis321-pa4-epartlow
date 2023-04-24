using pa4_epartlow.Interfaces;

namespace pa4_epartlow
{
    public class PistolDefense : IDefend
    {
        public void Defend()
        {
            System.Console.WriteLine("Elizabeth Swann defended herself with her pistol!");
        }
    }
}