using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class WhiteFlagSprite : AnimatedSprite
    {

        protected override Vector2 FrameSource => SpriteUtility.whiteFlagFrameSource;

        public WhiteFlagSprite(Texture2D texture) : base(texture, SpriteUtility.whiteFlagFrames, SpriteUtility.whiteFlagWidth, SpriteUtility.whiteFlagHeight)
        {
           
        }
    }

}
