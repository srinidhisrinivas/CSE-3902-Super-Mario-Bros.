using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    internal class MediumBushSprite : AnimatedSprite
    {

        protected override Vector2 FrameSource => SpriteUtility.mediumBushFrameSource;

        public MediumBushSprite(Texture2D texture) : base(texture, SpriteUtility.mediumBushFrames, SpriteUtility.mediumBushWidth, SpriteUtility.mediumBushHeight)
        {

        }
        
    }
}