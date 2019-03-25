using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class FireMarioRightRunSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.fireMarioRightRunFrameSource;
        protected override float FrameOffset => SpriteUtility.fireMarioRightRunOffset;


        public FireMarioRightRunSprite(Texture2D texture) : base(texture, SpriteUtility.runMarioFrames, SpriteUtility.fireMarioRunWidth, SpriteUtility.fireMarioRightRunHeight)
        {
           
        }
    }

}
