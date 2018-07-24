using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.A.F.Spell
{
    public class Spells
    {
        protected double originalCD; //cd
        protected double recupCD; //temps qu'il restepour avoir le spell
        protected byte degat;
        protected int portee; //portée 
        protected byte vitesseDeProjectile;
        protected byte debufInflige;
    }
}
