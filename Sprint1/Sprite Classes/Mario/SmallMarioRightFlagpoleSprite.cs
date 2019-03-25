using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class SmallMarioRightFlagpoleSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.smallMarioRightFlagpoleFrameSource;
        protected override float FrameOffset => SpriteUtility.smallMarioRightFlagpoleOffset;


        public SmallMarioRightFlagpoleSprite(Texture2D texture) : base(texture, SpriteUtility.flagpoleMarioFrames, SpriteUtility.smallMarioFlagpoleWidth, SpriteUtility.smallMarioFlagpoleHeight)
        {
            
           
        }
      

    }

}
