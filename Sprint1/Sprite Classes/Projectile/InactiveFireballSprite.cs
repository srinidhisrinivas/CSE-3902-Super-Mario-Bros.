using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class InactiveFireballSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.inactiveFireballFrameSource;
        protected override float FrameOffset => SpriteUtility.inactiveFireballOffset;


        public InactiveFireballSprite(Texture2D texture) : base(texture,SpriteUtility.inactiveFireballFrames, SpriteUtility.inactiveFireballWidth, SpriteUtility.inactiveFireballHeight)
        {
            
        }
        public override Rectangle GetRectangle(Vector2 location)
        {
            return new Rectangle();
        }
    }

}
