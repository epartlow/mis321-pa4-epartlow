using pa4_epartlow.Interfaces;

namespace pa4_epartlow
{
    public class DistractDefense : IDefend
    {
        public void Defend()
        {
            System.Console.WriteLine("Jack Sparrow distracted you mid-attack!");
        }
    }
}