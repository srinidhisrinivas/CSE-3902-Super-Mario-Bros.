using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class Star : Item
    {
        public Star(Vector2 location) : base(location)
        {
            this.ItemState = new AnimatedItemState(this);
            this.xVelocity = 3f;
            this.yVelocity = -15f;
            ItemSprite = ItemSpriteFactory.Instance.CreateStarSprite();
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

        }
        public override void Bounce()
        {
            this.yVelocity = -15f;
        }

    }
}
