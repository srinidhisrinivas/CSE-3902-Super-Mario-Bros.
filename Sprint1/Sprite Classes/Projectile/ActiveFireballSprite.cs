using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class ActiveFireballSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.activeFireballFrameSource;
        protected override float FrameOffset => SpriteUtility.activeFireballOffset;


        public ActiveFireballSprite(Texture2D texture) : base(texture, SpriteUtility.activeFireballFrames, SpriteUtility.activeFireballWidth, SpriteUtility.activeFireballHeight)
        {
            
        }
    }

}
