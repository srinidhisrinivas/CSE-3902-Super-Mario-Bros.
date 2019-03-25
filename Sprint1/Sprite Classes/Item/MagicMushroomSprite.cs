using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class MagicMushroomSprite : AnimatedSprite
    {

        protected override Vector2 FrameSource => SpriteUtility.magicMushroomFrameSource;

        public MagicMushroomSprite(Texture2D texture) : base(texture, SpriteUtility.mushroomFrames, SpriteUtility.mushroomWidth, SpriteUtility.mushroomHeight)
        {

        }
    }

}
