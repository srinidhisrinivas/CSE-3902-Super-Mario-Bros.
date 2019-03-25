using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class LeftKoopaSprite : AnimatedSprite
    {

        protected override Vector2 FrameSource => SpriteUtility.koopaFrameSource;
        protected override float FrameOffset => SpriteUtility.koopaFrameOffset;


        public LeftKoopaSprite(Texture2D texture) : base(texture, SpriteUtility.koopaFrames, SpriteUtility.koopaWidth, SpriteUtility.koopaHeight)
        {
           
        }

    }

}
