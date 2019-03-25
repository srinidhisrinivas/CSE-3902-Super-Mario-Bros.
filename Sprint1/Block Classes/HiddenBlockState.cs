using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{ 
    class HiddenBlockState : IBlockState
    {
        ISprite sprite;
        Vector2 location;

        public HiddenBlockState(Vector2 location)
        {
            this.location = location;
            sprite = ObjectSpriteFactory.Instance.CreateHiddenBlockSprite();
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
