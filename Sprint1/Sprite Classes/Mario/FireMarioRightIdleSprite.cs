using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class FireMarioRightIdleSprite : AnimatedSprite
    {

        protected override Vector2 FrameSource => SpriteUtility.fireMarioRightIdleFrameSource;

        public FireMarioRightIdleSprite(Texture2D texture) : base(texture, SpriteUtility.staticMarioFrames, SpriteUtility.bigMarioIdleWidth, SpriteUtility.bigMarioIdleHeight)
        {
            
        }
        
    }

}
