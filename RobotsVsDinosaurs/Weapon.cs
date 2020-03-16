using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {
        public string dinosaurAttack1;
        public string dinosaurAttack2;
        public string dinosaurAttack3;
        public double attackPower;
        public string robotsAttack1;
        public string robotsAttack2;
        public string robotsAttack3;

        public Weapon(string dinosaurAttack1, string dinosaurAttack2, string dinosaurAttack3, double attackPower, string robotsAttack1, string robotsAttack2, string robotsAttack3)
        {
            this.dinosaurAttack1 = dinosaurAttack1;
            this.dinosaurAttack2 = dinosaurAttack2;
            this.dinosaurAttack3 = dinosaurAttack3;
            this.attackPower = attackPower;
            this.robotsAttack1 = robotsAttack1;
            this.robotsAttack2 = robotsAttack2;
            this.robotsAttack3 = robotsAttack3;
        }
    }
}
