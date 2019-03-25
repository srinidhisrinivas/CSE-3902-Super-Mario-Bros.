using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class MediumPipeSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.mediumPipeFrameSource;

        public MediumPipeSprite(Texture2D texture) : base(texture, SpriteUtility.mediumPipeFrames, SpriteUtility.mediumPipeWidth, SpriteUtility.mediumPipeHeight)
        {
            
        }
        
    }

}
