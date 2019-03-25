using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class RedBrickBlockSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.redBrickFrameSource;

        public RedBrickBlockSprite(Texture2D texture) : base(texture, SpriteUtility.blockFrames, SpriteUtility.blockWidth, SpriteUtility.blockHeight)
        {
            
        }
        
    }

}
