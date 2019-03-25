using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    internal class LittleHillSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.littleHillFrameSource;

        public LittleHillSprite(Texture2D texture) : base(texture, SpriteUtility.littleHillFrames, SpriteUtility.littleHillWidth, SpriteUtility.littleHillHeight)
        {

        }

    }
}