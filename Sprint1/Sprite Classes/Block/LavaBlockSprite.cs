using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class LavaBlockSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => BlockUtility.lavaBlockSpriteFrameSource;
        public LavaBlockSprite(Texture2D texture) : base(texture, BlockUtility.one, BlockUtility.lavaBlockXlocation, BlockUtility.lavaBlockYlocation)
        {

        }
    }
}