using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        string fleet = "fleet";
        string herd = "herd";
        int fleetHealth = 100;
        int herdHealth = 100;
        int fleetAttackPower = 50;
        int herdAttackPower = 50;

        public void RunFight()
        {
            Console.WriteLine("Starting battle between dinosaurs and robots!");
            Console.ReadLine();
        }

        public Battlefield(int Health, int AttackPower)
        {

        }

        public void Run()
        {
            Console.WriteLine("this is the battle");
            Console.ReadLine();

            RunFight();
        }


    }
}
