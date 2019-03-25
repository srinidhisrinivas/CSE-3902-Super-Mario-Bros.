using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class BigMarioLeftFlagpoleSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.bigMarioLeftFlagpoleFrameSource;
        protected override float FrameOffset => SpriteUtility.marioLeftFlagpoleOffset;


        public BigMarioLeftFlagpoleSprite(Texture2D texture) : base(texture, SpriteUtility.flagpoleMarioFrames, SpriteUtility.bigMarioFlagpoleWidth, SpriteUtility.bigMarioFlagpoleHeight)
        {
            
           
        }
        

    }

}
