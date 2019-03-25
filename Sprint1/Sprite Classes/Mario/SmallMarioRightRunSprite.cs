using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class SmallMarioRightRunSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.smallMarioRightRunFrameSource;
        protected override float FrameOffset => SpriteUtility.smallMarioRightRunOffset;


        public SmallMarioRightRunSprite(Texture2D texture) : base(texture, SpriteUtility.runMarioFrames, SpriteUtility.smallMarioRunWidth, SpriteUtility.smallMarioRunHeight)
        {
            
        }
    }

}
