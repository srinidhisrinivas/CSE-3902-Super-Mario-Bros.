using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CastleSprite : AnimatedSprite
    {

        protected override Vector2 FrameSource => SpriteUtility.castleFrameSource;

        public CastleSprite(Texture2D texture) : base(texture, SpriteUtility.castleFrames, SpriteUtility.castleWidth, SpriteUtility.castleHeight)
        {
           
        }
        
    }

}
