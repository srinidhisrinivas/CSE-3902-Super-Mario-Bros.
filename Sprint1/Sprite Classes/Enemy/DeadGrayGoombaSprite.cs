using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class DeadGrayGoombaSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => BlockUtility.deadGrayGoombaSpriteFrameSource;
        protected override SpriteEffects SpriteEffects => SpriteEffects.FlipVertically;
        public DeadGrayGoombaSprite(Texture2D texture) : base(texture, BlockUtility.one, BlockUtility.deadGrayGoombaXlocation, BlockUtility.deadGrayGoombaYlocation)
        {

        }
        public override Rectangle GetRectangle(Vector2 location)
        {
            return new Rectangle();
        }
    }
}