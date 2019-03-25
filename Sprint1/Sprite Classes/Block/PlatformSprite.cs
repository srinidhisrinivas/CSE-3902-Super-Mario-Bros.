﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class PlatformSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => BlockUtility.platformSpriteFrameSource;

        public PlatformSprite(Texture2D texture) : base(texture, BlockUtility.one, BlockUtility.platformXlocation, BlockUtility.platformYlocation)
        {

        }

    }

}