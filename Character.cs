using pa4_epartlow.Interfaces;

namespace pa4_epartlow
{
    public class Character
    {
        public string playerName {get; set;}
        public string characterName {get; set;}
        public int maxPower {get; set;}
        public double health {get; set;}
        public int attackStrength {get; set;}
        public int defensivePower {get; set;}
        public IAttack attackBehavior {get; set;}
        public IDefend defendBehavior {get; set;}

        public Character()
        {

        }
        public int GetMaxPower()
        {
            Random randomNum = new Random();
            maxPower = randomNum.Next(1,101);
            return maxPower;
        }
        public int GetAttackStrength()
        {
            Random randomNum = new Random();
            attackStrength = randomNum.Next(1, maxPower + 1);
            return attackStrength;
        }
        public int GetDefensivePower()
        {
            Random randomNum = new Random();
            attackStrength = randomNum.Next(1, maxPower + 1);
            return attackStrength;
        }  
    }
}