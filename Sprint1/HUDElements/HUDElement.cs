using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class HUDElement : IHUDElement
    {
        protected ITextContent textContent { get; set; }
        protected Color textColor { get; set; }
        protected SpriteFont font { get; set; }

        public Vector2 Location { get; set; }
        protected HUDElement(ITextContent textContent, Vector2 location)
        {
            this.textColor = Color.White;
            this.textContent = textContent;
            this.Location = location;
        }
        public virtual void Update(GameTime gameTime)
        {
            textContent.Update(gameTime);
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            textContent.Draw(spriteBatch, font, Location, textColor);
        }

    }
    
}
