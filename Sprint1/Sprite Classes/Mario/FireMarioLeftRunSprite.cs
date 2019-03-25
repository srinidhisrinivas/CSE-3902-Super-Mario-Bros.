using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class FireMarioLeftRunSprite : AnimatedSprite
    {

        protected override Vector2 FrameSource => SpriteUtility.fireMarioLeftRunFrameSource;
        protected override float FrameOffset =>SpriteUtility.fireMarioLeftRunOffset;


        public FireMarioLeftRunSprite(Texture2D texture) : base(texture, SpriteUtility.runMarioFrames, SpriteUtility.fireMarioRunWidth, SpriteUtility.fireMarioLeftRunHeight)
        {
            
        }
    }

}
