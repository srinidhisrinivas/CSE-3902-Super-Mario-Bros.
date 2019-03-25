using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class LavaSurfaceSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => BlockUtility.lavaSurfaceSpriteFrameSource;
        public LavaSurfaceSprite(Texture2D texture) : base(texture, BlockUtility.one, BlockUtility.lavaSurfaceXlocation, BlockUtility.lavaSurfaceYlocation)
        {

        }
    }
}