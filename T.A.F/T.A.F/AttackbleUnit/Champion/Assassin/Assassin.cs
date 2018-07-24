using System;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.A.F.AttackbleUnit.Champion.Assassin
{
    public class Assassin : Champion
    {
        public Assassin(int _X, int _Y, String _name)
        {
            Y = _Y;
            X = _X;
            name = _name;
            canMove = true;
            vitesse = 5;


        }

        public void Spell1() {

        }

        public void Spell2() {

        }

        public void Spell3() {

        }

        public void Dash() {
            if (Keyboard.GetState().IsKeyDown(Keys.Z)) Y = Y + 15;
            if (Keyboard.GetState().IsKeyDown(Keys.S)) Y = Y - 15;
            if (Keyboard.GetState().IsKeyDown(Keys.D)) X = X + 15;
            if (Keyboard.GetState().IsKeyDown(Keys.Q)) X = X - 15;
        }

    }
}
