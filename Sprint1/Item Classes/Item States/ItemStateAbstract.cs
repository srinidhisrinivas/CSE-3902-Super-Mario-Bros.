using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class ItemStateAbstract : IItemState
    {
        public ISprite ItemSprite { get; set; }
        public virtual Rectangle HitBox { get => ItemSprite.GetRectangle(Item.Location);  }
        protected IItem Item { get; set; }
        protected ItemStateAbstract(IItem item)
        {
            this.Item = item;
        }

        public virtual void Draw(SpriteBatch spriteBatch, Color color)
        {
            ItemSprite.Draw(spriteBatch, Item.Location, color);
        }
        public virtual void Bounce()
        {
        
        }

        
        public virtual void Update(GameTime gameTime)
        {
            ItemSprite.Update(gameTime);
        }
    }
}
