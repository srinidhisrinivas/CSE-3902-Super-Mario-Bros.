using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public interface IBackgroundObject : ILocateable
    {
        void Draw(SpriteBatch spriteBatch, Color color);
    }
}