using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class ActiveFireballState : ItemStateAbstract
    {
        public ActiveFireballState(IItem item) : base(item)
        {
            this.Item = item;
            this.ItemSprite = ItemSpriteFactory.Instance.CreateActiveFireballSprite();
        }
        public override void Explode(Vector2 location)
        {
            Item.StopMotionX();
            Item.StopMotionY();
            Item.yAcceleration = 0f;
            Item.ItemState = new InactiveFireballState(Item);
        }

    }
}