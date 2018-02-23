using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warriors
{
    class Fighter
    {
        private int hp, atk, def, luck, skl;
        private String name;

        public int Hp//get set methods for hp
        {
            get
            {
                return hp;
            }
            set {
                hp = value;
            }
        }//hp get set methods
        public int Atk//get set methods for atk
        {
            get
            {
                return atk;
            }
            set
            {
                atk = value;
            }
        }//atk get set methods
        public int Def//get set methods for def 
        {
            get
            {
                return def;
            }
            set
            {
                def = value;
            }
        }//get set methods foor def
        public String Name//get set methods for name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }//get set methods for name
        public int Luck//get set methods for luck
        {
            get
            {
                return luck;
            }
            set
            {
                luck = value;
            }
        }//get set methods for luck
        public int Skl//get set methods for skill
        {
            get
            {
                return skl;
            }
            set
            {
                skl = value;
            }
        }//get set methods for skill

        public Fighter(String n, int h, int a, int d, int l, int s)
        {
            Name = n;
            Hp = h;
            Atk = a;
            Def = d;
            Luck = l;
            Skl = s;
            
        }
    }
}
