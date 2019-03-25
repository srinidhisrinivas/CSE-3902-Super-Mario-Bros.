using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class Item : UniversalPhysics, IItem
    {
        public Rectangle HitBox { get => ItemState.HitBox; }
        public IItemState ItemState { get; set; }
        protected Item(Vector2 location) : base(location)
        {

        }
        
        public virtual void ChangeDirection()
        {
            this.xVelocity *= -1f;
        }
        public virtual void Bounce()
        {
            ItemState.Bounce();
        }
        
        public virtual void Draw(SpriteBatch spriteBatch, Color color)
        {
            ItemState.Draw(spriteBatch, color);
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            ItemState.Update(gameTime);
        }
    }
}
