using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class FireMarioLeftJumpSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.fireMarioLeftJumpFrameSource;

        public FireMarioLeftJumpSprite(Texture2D texture) : base(texture, SpriteUtility.staticMarioFrames, SpriteUtility.fireMarioJumpWidth, SpriteUtility.bigMarioJumpHeight)
        {
            
        }
    }

}
