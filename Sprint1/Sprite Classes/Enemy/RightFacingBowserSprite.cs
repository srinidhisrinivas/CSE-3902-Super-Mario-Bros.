using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class RightFacingBowserSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => BlockUtility.rightFacingBowserSpriteFrameSource;
        protected override float FrameOffset => BlockUtility.rightFacingBowserFrameOffset;
        protected override SpriteEffects SpriteEffects => SpriteEffects.FlipHorizontally;
        public RightFacingBowserSprite(Texture2D texture) : base(texture, BlockUtility.four, BlockUtility.rightFacingBowserXlocation, BlockUtility.rightFacingBowserYlocation)
        {

        }
    }
}