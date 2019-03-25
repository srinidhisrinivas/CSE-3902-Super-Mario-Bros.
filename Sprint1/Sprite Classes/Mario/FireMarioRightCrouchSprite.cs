using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class FireMarioRightCrouchSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.fireMarioRightCrouchFrameSource;

        public FireMarioRightCrouchSprite(Texture2D texture) : base(texture, SpriteUtility.staticMarioFrames, SpriteUtility.bigMarioCrouchWidth, SpriteUtility.bigMarioCrouchHeight)
        {

        }
        
    }

}
