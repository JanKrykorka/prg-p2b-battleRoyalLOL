using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace battleRoyal
{
    class Enemy
    {
        private int health;
        private int maxHealth;
        private int attackPower;
        public Enemy(int health, int attack) 
        {
            this.health = health;
            this.maxHealth = health;
            this.attackPower = attack;
        }
        public bool HeLivin { get { return (health > 0); } }

        public string HealthBar() 
        {
            string s = "[";
            int i = 20;
            double space = Math.Round(((double)health / maxHealth) * i);
            if ((space == 0) && (HeLivin))
                space = 1;
            for (int j = 0; j < space; j++)
                s += "#";
            s = s.PadRight(i + 1);
            s += "]";
            return s;
        }


        public Enemy PickOpponent(Enemy[] opponents)
        {
            int i = Random.Shared.Next(opponents.Length);
            return opponents[i];
        }

        public int ReceiveDamage(int incomingDamage)
        {
            if (incomingDamage > health)
                health = 0;
            else
                health -= incomingDamage;
            return health;
        }

        public int Attack( Enemy target)
        {
            Console.WriteLine(this + "hits" + target + "for" + attackPower);
            return target.ReceiveDamage(attackPower);
        }


        


     






    }
}
