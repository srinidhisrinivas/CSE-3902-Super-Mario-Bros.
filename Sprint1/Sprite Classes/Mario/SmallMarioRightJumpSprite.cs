using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class SmallMarioRightJumpSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.smallMarioRightJumpFrameSource;

        public SmallMarioRightJumpSprite(Texture2D texture) : base(texture, SpriteUtility.staticMarioFrames, SpriteUtility.smallMarioJumpWidth, SpriteUtility.smallMarioJumpHeight)
        {
            
        }
        public override Rectangle GetRectangle(Vector2 location)
        {
            return new Rectangle((int)location.X, (int)location.Y - FrameScale * FrameHeight, FrameScale * FrameWidth - 2, FrameScale * FrameHeight);
        }

    }

}
