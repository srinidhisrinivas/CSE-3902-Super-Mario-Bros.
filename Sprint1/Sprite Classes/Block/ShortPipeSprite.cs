using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class ShortPipeSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.shortPipeFrameSource;

        public ShortPipeSprite(Texture2D texture) : base(texture, SpriteUtility.shortPipeFrames, SpriteUtility.shortPipeWidth, SpriteUtility.shortPipeHeight)
        {
            
        }
        
    }

}
