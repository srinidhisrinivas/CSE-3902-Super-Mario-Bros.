using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class RedCrackedBlockSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.crackedRedBrickFrameSource;
        
        public RedCrackedBlockSprite(Texture2D texture) : base(texture, SpriteUtility.blockFrames, SpriteUtility.blockWidth, SpriteUtility.blockHeight)
        {
            
        }
        

    }

}
