using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public interface ITextContent
    {
        void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont, Vector2 location, Color textColor);
        void Update(GameTime gameTime);

    }

}