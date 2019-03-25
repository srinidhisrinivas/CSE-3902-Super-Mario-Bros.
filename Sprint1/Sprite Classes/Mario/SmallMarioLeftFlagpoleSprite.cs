using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class SmallMarioLeftFlagpoleSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.smallMarioLeftFlagpoleFrameSource;
        protected override float FrameOffset => SpriteUtility.smallMarioLeftFlagpoleOffset;


        public SmallMarioLeftFlagpoleSprite(Texture2D texture) : base(texture, SpriteUtility.flagpoleMarioFrames, SpriteUtility.smallMarioFlagpoleWidth, SpriteUtility.smallMarioFlagpoleHeight)
        {
            
           
        }
        

    }

}
