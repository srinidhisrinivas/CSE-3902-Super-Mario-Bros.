using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class RightBrick : Item
    {
        public RightBrick(Vector2 location) : base(location)
        {
            this.ItemState = new AnimatedItemState(this);
            this.ItemSprite = ObjectSpriteFactory.Instance.CreateRightBrickSprite();
        }
    }
}
