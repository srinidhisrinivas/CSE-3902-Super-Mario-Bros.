using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class FlagpoleSprite : AnimatedSprite
    {

        protected override Vector2 FrameSource => SpriteUtility.flagpoleFrameSource;

        public FlagpoleSprite(Texture2D texture) : base(texture, SpriteUtility.flagpoleFrames, SpriteUtility.flagpoleWidth, SpriteUtility.flagpoleHeight)
        {
           
        }
    }

}
