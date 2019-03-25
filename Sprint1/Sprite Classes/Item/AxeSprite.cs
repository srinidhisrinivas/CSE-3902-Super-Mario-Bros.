using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class AxeSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => BlockUtility.axeSpriteFrameSource;
        protected override float FrameOffset => BlockUtility.axeFrameOffset;
        public AxeSprite(Texture2D texture) : base(texture, BlockUtility.three, BlockUtility.axeXlocation, BlockUtility.axeYlocation)
        {

        }
    }
}