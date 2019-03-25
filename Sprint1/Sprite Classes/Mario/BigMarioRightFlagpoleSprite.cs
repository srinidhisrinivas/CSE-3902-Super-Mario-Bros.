using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class BigMarioRightFlagpoleSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.bigMarioRightFlagpoleFrameSource;
        protected override float FrameOffset => SpriteUtility.marioRightFlagpoleOffset;


        public BigMarioRightFlagpoleSprite(Texture2D texture) : base(texture, SpriteUtility.flagpoleMarioFrames, SpriteUtility.bigMarioFlagpoleWidth, SpriteUtility.bigMarioFlagpoleHeight)
        {
            
           
        }
       
    }

}
