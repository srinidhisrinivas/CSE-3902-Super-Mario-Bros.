using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class DeadMarioSprite : AnimatedSprite
    {

        protected override Vector2 FrameSource => SpriteUtility.deadMarioFrameSource;

        public DeadMarioSprite(Texture2D texture) : base(texture, SpriteUtility.staticMarioFrames, SpriteUtility.deadMarioWidth, SpriteUtility.deadMarioHeight)
        {
          
        }
        public override Rectangle GetRectangle(Vector2 location)
        {
            return new Rectangle();
        }
        
    }
    

}
