using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class InactiveFireballState : ItemStateAbstract
    {
        private int timer;
        public InactiveFireballState(IItem item) : base(item)
        {
            timer = 30;
            this.ItemSprite = ItemSpriteFactory.Instance.CreateInactiveFireballSprite();
        }
        public override void Explode(Vector2 location)
        {
            
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if(timer-- == 0)
            {
                LevelEditFactory.Instance.RemoveItem(Item);
            }

        }

    }
}