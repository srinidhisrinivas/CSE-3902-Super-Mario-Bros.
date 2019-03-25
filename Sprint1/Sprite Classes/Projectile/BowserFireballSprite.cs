using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class BowserFireballSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => BlockUtility.bowserFireballSpriteFrameSource;
        protected override float FrameOffset => BlockUtility.bowserFireballFrameOffset;
        public BowserFireballSprite(Texture2D texture) : base(texture, BlockUtility.two, BlockUtility.bowserFireballXlocation, BlockUtility.bowserFireballYlocation)
        {

        }
    }
}