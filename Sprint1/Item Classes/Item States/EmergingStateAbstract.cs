using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class EmergingStateAbstract : ItemStateAbstract
    {
        private int blockTopLocation;
        private int blockHeight;
        public override Rectangle HitBox {get => new Rectangle(); }
        protected Type emergedItemStateType { get; set; }
        protected EmergingStateAbstract(IItem item): base(item)
        {
            blockHeight = SpriteUtility.scaledBlockHeight;
            blockTopLocation = (int)Item.Location.Y - blockHeight;
            Item.yAcceleration = PhysicsUtility.suspendedGravity;
        }
        
        public override void Update(GameTime gameTime)
        {
            ItemSprite.Update(gameTime);
            Item.Location -= ItemUtility.emergingItemDisplacement;
            if (Item.Location.Y == blockTopLocation)
            {
                Item.ResetGravity();
                Item.ItemState = (IItemState)Activator.CreateInstance(emergedItemStateType, Item);
            }
        }
    }
}
