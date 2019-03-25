using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class NullFloorPiece : IFloorPiece
    {
        public Rectangle HitBox => new Rectangle();
        public NullFloorPiece()
        {

        }
        public void Update(GameTime gameTime)
        {


        }
        public void Draw(SpriteBatch spriteBatch, Color color)
        {

        }
    }
}