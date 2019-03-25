using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class LeftFacingBowserSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => BlockUtility.leftFacingBowserSpriteFrameSource;
        protected override float FrameOffset => BlockUtility.leftFacingBowserFrameOffset;
        public LeftFacingBowserSprite(Texture2D texture) : base(texture, BlockUtility.four, BlockUtility.leftFacingBowserXlocation, BlockUtility.leftFacingBowserYlocation)
        {

        }
    }
}