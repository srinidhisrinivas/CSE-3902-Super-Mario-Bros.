using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    internal class BigCloudSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.bigCloudFrameSource;

        public BigCloudSprite(Texture2D texture) : base(texture, SpriteUtility.bigCloudFrames, SpriteUtility.bigCloudWidth, SpriteUtility.bigCloudHeight)
        {

        }

    }
}