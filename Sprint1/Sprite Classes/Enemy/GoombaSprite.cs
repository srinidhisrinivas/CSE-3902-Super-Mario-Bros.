using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class GoombaSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.goombaFrameSource; 
        protected override float FrameOffset => SpriteUtility.goombaFrameOffset;


        public GoombaSprite(Texture2D texture) : base(texture, SpriteUtility.goombaFrames, SpriteUtility.goombaWidth, SpriteUtility.goombaHeight)
        {
            
        }
    }

}
