using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class BackgroundObject : IBackgroundObject
    {
        public Vector2 Location { get; set; }
        protected ISprite Sprite { get; set; }
        protected BackgroundObject(Vector2 location)
        {
            this.Location = location;
        }
        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            Sprite.Draw(spriteBatch, this.Location, color);
        }
    }
}
