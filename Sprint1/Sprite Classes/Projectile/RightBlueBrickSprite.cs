using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class RightBlueBrickSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.rightBlueBrickFrameSource;

        public RightBlueBrickSprite(Texture2D texture): base(texture, SpriteUtility.brickFrames, SpriteUtility.brickWidth, SpriteUtility.brickHeight)
        {

        }
        public override Rectangle GetRectangle(Vector2 location)
        {
            return new Rectangle();
        }
    }
}
