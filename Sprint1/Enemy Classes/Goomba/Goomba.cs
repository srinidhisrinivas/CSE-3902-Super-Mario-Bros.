using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class Goomba : Enemy
    {
        public Goomba(Vector2 location) : base(location)
        {
            this.State = new LeftMovingGoombaState(this);
        }


    }
}