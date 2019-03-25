using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class DeadKoopaSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.deadKoopaFrameSource;
        protected override SpriteEffects SpriteEffects => SpriteEffects.FlipVertically;


        public DeadKoopaSprite(Texture2D texture) : base(texture, SpriteUtility.staticKoopaFrames, SpriteUtility.koopaWidth, SpriteUtility.stompedKoopaHeight)
        {
           
        }
        public override Rectangle GetRectangle(Vector2 location)
        {
            return new Rectangle();
        }

        

    }

}
