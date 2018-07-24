using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.A.F.AttackbleUnit
{
    public class AttackbleUnit
    {
        protected bool canMove;
        protected int X;
        protected int Y;
        protected byte type;
        protected bool isAlive;
        protected int hp;
        protected int maxHP;
        protected int attaque;
        protected int defense;
        protected int vitesse;
        protected String name;
        protected int[] inventaire;
        protected const byte maxInventaireLenght = 6;

        public String GetName() {
            return name;
        }

        public void MoveForward(bool sens) //move u on the Y axe
        {
            if (sens && canMove) Y = Y + vitesse; //avance
            else Y = Y - vitesse; //recule
            if (Y > 565) Y = 565;
            if (Y < 0) Y = 0;
        }

        public void MoveSide(bool sens)
        {
            if (sens && canMove) X = X + vitesse;
            else X = X - vitesse;
            if (X > 753) X = 753;
            if (X < 0) X = 0;
        }

        public int GetX() {
            return X;
        }

        public int GetY()
        {
            return Y;
        }

    }
}
