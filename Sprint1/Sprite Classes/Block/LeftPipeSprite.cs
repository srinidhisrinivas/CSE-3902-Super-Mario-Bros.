using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class LeftPipeSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.leftPipeFrameSource;

        public LeftPipeSprite(Texture2D texture) : base(texture, SpriteUtility.leftPipeFrames, SpriteUtility.leftPipeWidth, SpriteUtility.leftPipeHeight)
        {
            
        }

    }

}
