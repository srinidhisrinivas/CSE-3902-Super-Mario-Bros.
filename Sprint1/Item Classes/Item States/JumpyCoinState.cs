using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    public class JumpyCoinState : ItemStateAbstract
    {
        private int disappearHeight;
        public JumpyCoinState(IItem item) : base(item)
        {
            disappearHeight = (int)item.Location.Y - ItemUtility.coinDisappearHeight;
            Item.StopMotionX();
            Item.yVelocity = ItemUtility.coinVelocity;
            this.ItemSprite = ItemSpriteFactory.Instance.CreateSpinningCoinSprite();
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if(Item.VerticalMotionState is FallingState && Item.Location.Y > disappearHeight)
            {
                new CommandConsumeCoin(Game1.Instance.Mario, Item).Execute();
                LevelEditFactory.RemoveItem(Item);
            }
        }


    }
}
