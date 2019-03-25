using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class SmallMarioLeftRunSprite : AnimatedSprite
    {

        protected override Vector2 FrameSource => SpriteUtility.smallMarioLeftRunFrameSource;
        protected override float FrameOffset => SpriteUtility.smallMarioLeftRunOffset;


        public SmallMarioLeftRunSprite(Texture2D texture) : base(texture, SpriteUtility.runMarioFrames, SpriteUtility.smallMarioRunWidth, SpriteUtility.smallMarioRunHeight)
        {
            
        }
    }

}
