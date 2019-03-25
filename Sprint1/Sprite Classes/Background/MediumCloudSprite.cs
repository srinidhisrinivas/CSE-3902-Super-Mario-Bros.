using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    internal class MediumCloudSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.mediumCloudFrameSource;

        public MediumCloudSprite(Texture2D texture) : base(texture, SpriteUtility.mediumCloudFrames, SpriteUtility.mediumCloudWidth, SpriteUtility.mediumCloudHeight)
        {
            
        }
        
    }
}