using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class DeadGoombaSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.deadGoombaFrameSource;
        protected override SpriteEffects SpriteEffects => SpriteEffects.FlipVertically;


        public DeadGoombaSprite(Texture2D texture) : base(texture, SpriteUtility.staticGoombaFrames, SpriteUtility.goombaWidth, SpriteUtility.goombaHeight)
        {
            
        }
        public override Rectangle GetRectangle(Vector2 location)
        {
            return new Rectangle();
        }

    }

}
