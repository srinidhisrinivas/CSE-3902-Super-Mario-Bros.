using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    public class BouncyStarState : ItemStateAbstract
    {
        private float bounceVelocity;
        public BouncyStarState(IItem item) : base(item)
        {
            this.bounceVelocity = ItemUtility.starBounceVelocity;
            Item.yVelocity = bounceVelocity;
            Item.xVelocity = ItemUtility.starXVelocity;
            this.ItemSprite = ItemSpriteFactory.Instance.CreateStarSprite();
        }
       
        public override void Bounce()
        {
            Item.yVelocity = bounceVelocity;
        }

    }
}
