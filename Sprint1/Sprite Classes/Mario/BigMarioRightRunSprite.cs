﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class BigMarioRightRunSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.bigMarioRightRunFrameSource;
        protected override float FrameOffset => SpriteUtility.marioRightRunOffset;


        public BigMarioRightRunSprite(Texture2D texture) : base(texture, SpriteUtility.runMarioFrames, SpriteUtility.bigMarioRunWidth, SpriteUtility.bigMarioRunHeight)
        {
            
            
        }
    }

}
