using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class FireMarioRightFlagpoleSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.fireMarioRightFlagpoleFrameSource;
        protected override float FrameOffset => SpriteUtility.marioRightFlagpoleOffset;


        public FireMarioRightFlagpoleSprite(Texture2D texture) : base(texture, SpriteUtility.flagpoleMarioFrames, SpriteUtility.bigMarioFlagpoleWidth, SpriteUtility.bigMarioFlagpoleHeight)
        {
            
           
        }
        
    }

}
