using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warriors
{
    class Battle {
        private Random r = new Random();
        public Battle(Fighter a, Fighter b)//main class instantiation
        {
            
            Console.WriteLine($"{a.Name} VS {b.Name}");

            while (Alive(a)&&Alive(b))
            {
                Console.WriteLine($"{a.Name} Hp: {a.Hp.ToString()} | {b.Name} Hp: {b.Hp.ToString()}");
                Attack(a,b);
                if (Lost(a) || Lost(b)) {
                    break;
                }
                    Console.WriteLine($"{a.Name} Hp: {a.Hp.ToString()} | {b.Name} Hp: {b.Hp.ToString()}");
                    Attack(b, a);

            }
            Results(a, b);

        }//End of main class instantiation 

        private void Attack(Fighter a, Fighter b) {
                
                int damage;
            int v = b.Atk - 50;
                damage = r.Next(v, b.Atk);
                a.Hp -= damage;
            
                Console.WriteLine($"{b.Name} Attacked {a.Name}!");
                Console.WriteLine($"{a.Name} Loses {damage} Hp!");
            }
        private void Results(Fighter a, Fighter b)
        {
            if (Alive(a))
            {
                Winner(a);
            }
            else
            {
                Winner(b);
            }
        }

        private void Winner(Fighter f)
        {
            Console.WriteLine($"WINNER IS {f.Name}");
        }

        private bool Alive(Fighter f)
        {
            return f.Hp > 0;
        }

        private bool Lost(Fighter f)
        {
            return f.Hp < 1;
        }
    }
}
