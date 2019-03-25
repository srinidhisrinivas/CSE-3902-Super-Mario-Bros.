using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class FlowerSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.flowerFrameSource;
        protected override float FrameOffset => SpriteUtility.flowerFrameOffset;


        public FlowerSprite(Texture2D texture) : base(texture, SpriteUtility.flowerFrames, SpriteUtility.flowerWidth, SpriteUtility.flowerHeight)
        {
            
        }
    }

}
