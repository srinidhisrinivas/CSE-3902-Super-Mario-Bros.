using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class StompedKoopaSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.stompedKoopaFrameSource;

        public StompedKoopaSprite(Texture2D texture) : base(texture, SpriteUtility.staticKoopaFrames, SpriteUtility.koopaWidth, SpriteUtility.stompedKoopaHeight)
        {
           
        }

    }

}
