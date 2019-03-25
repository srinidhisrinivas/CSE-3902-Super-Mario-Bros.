using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class BridgeLinkSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => BlockUtility.bridgeLinkSpriteFrameSource;
        public BridgeLinkSprite(Texture2D texture) : base(texture, BlockUtility.one, BlockUtility.bridgeLinkXlocation, BlockUtility.bridgeLinkYlocation)
        {

        }
    }
}