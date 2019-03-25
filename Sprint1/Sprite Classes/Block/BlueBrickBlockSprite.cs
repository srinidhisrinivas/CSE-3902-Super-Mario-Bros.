using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class BlueBrickBlockSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.blueBrickFrameSource;

        public BlueBrickBlockSprite(Texture2D texture) : base(texture, SpriteUtility.blockFrames, SpriteUtility.blockWidth, SpriteUtility.blockHeight)
        {
            
        }
        
    }

}
