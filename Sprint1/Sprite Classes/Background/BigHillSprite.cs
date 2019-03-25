using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class BigHillSprite : AnimatedSprite
    {

        protected override Vector2 FrameSource => SpriteUtility.bigHillFrameSource;

        public BigHillSprite(Texture2D texture) : base(texture, 1, 80, 35)
        {

        }
        
    }
}