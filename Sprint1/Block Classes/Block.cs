using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public abstract class Block : BlockPhysics, IBlock
    {
        public IItem PowerUp { get; set; }
        public Rectangle HitBox { get => BlockSprite.GetRectangle(Location); }
        public IBlockState BlockState { get; set; }
        public ISprite BlockSprite { get; set; }
        protected Block(Vector2 location) : base(location)
        {
            
            PowerUp = new NullItem(this.Location);
            this.VerticalMotionState = new IdleState();

        }
        public virtual void Draw(SpriteBatch spriteBatch, Color color)
        {
            BlockState.Draw(spriteBatch, color);
            BlockSprite.Draw(spriteBatch, Location, color);
        }
        public virtual void GetBumped()
        {
            BlockState.GetBumped();
        }
        public virtual void GetBroken()
        {
            BlockState.GetBroken();
        }
        public virtual void PerformAction()
        {
            LevelEditFactory.AddItem(this.PowerUp);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            BlockState.Update(gameTime);
            BlockSprite.Update(gameTime);
        }
    }
}
