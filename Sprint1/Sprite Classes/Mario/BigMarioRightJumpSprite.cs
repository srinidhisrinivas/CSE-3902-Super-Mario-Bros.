using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class BigMarioRightJumpSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.bigMarioRightJumpFrameSource;

        public BigMarioRightJumpSprite(Texture2D texture) : base(texture, SpriteUtility.staticMarioFrames, SpriteUtility.bigMarioJumpWidth, SpriteUtility.bigMarioJumpHeight)
        {
            
            
        }
    }
    

}
