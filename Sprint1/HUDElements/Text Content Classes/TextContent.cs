using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    
    public abstract class TextContent : ITextContent
    {
        protected string Text { get; set; }
        protected TextContent()
        {

        }
        public virtual void Update(GameTime gameTime)
        {

        }
        public virtual void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont, Vector2 location, Color textColor)
        {
            spriteBatch.DrawString(spriteFont, this.Text, location, textColor);
        }
    }
}