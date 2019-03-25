using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class StarSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.starFrameSource;
        protected override float FrameOffset => SpriteUtility.starOffset;


        public StarSprite(Texture2D texture) : base(texture, SpriteUtility.starFrames, SpriteUtility.starWidth, SpriteUtility.starHeight)
        {
            
        }
    }

}
