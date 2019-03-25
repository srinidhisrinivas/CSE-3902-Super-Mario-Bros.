using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class NullBackgroundObject : IBackgroundObject
    {
        public Vector2 Location { get => new Vector2(); set => Location = value; }
        public NullBackgroundObject()
        {
            
        }
        public void Draw(SpriteBatch spriteBatch, Color color)
        {
        }
    }
}