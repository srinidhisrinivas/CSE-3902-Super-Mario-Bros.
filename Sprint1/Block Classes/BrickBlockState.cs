using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class BrickBlockState:IBlockState
    {
        // FIX: Get rid of IBlock and use state pattern for blocks as with Mario.
        
        ISprite sprite;
        private Vector2 location;

        public BrickBlockState(Vector2 location)
        {
            sprite = ObjectSpriteFactory.Instance.CreateBrickBlockSprite();
            this.location = location;
        }
        public Rectangle GetRectangle()
        {
            return sprite.GetRectangle(location);
        }

        public void Update(GameTime gameTime)
        {
            sprite.Update(gameTime);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, location);
        }
    }
}
