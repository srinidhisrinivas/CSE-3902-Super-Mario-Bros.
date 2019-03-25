using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    internal class BigBushSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.bigBushFrameSource;

        public BigBushSprite(Texture2D texture) : base(texture, SpriteUtility.bigBushFrames, SpriteUtility.bigBushWidth, SpriteUtility.bigBushHeight)
        {

        }
        

    }
}