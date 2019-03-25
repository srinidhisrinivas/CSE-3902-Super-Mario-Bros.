using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class Fireball:Item
    {
        public Fireball(IMario mario, bool leftFacing) : base(mario.Location)
        {
            if (leftFacing) {
            this.xVelocity = mario.xVelocity -6f;
            }
            else
            {
                this.xVelocity = mario.xVelocity + 6f;
            }
            this.Location = new Vector2(mario.Location.X, mario.Location.Y - mario.HitBox.Height/2f);
            this.yVelocity = -2f;
            this.ItemState = new ActiveFireballState(this);
        }
        public override void Explode(Vector2 location)
        {
            ItemState.Explode(location);
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            ItemState.Update(gameTime);

        }
        public override void Bounce()
        {
            this.yVelocity = -10f;
        }
    }
}
