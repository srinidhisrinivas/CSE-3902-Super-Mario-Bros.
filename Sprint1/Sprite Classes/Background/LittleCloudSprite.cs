using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    internal class LittleCloudSprite : AnimatedSprite
    {

        protected override Vector2 FrameSource => SpriteUtility.littleCloudFrameSource;

        public LittleCloudSprite(Texture2D texture) : base(texture, SpriteUtility.littleCloudFrames, SpriteUtility.littleCloudWidth, SpriteUtility.littleCloudHeight)
        {

        }
        

    }
}