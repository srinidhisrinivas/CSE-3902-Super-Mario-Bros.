using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    internal class LittleBushSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.littleBushFrameSource;

        public LittleBushSprite(Texture2D texture) : base(texture, SpriteUtility.littleBushFrames, SpriteUtility.littleBushWidth, SpriteUtility.littleBushHeight)
        {

        }
        

    }
}