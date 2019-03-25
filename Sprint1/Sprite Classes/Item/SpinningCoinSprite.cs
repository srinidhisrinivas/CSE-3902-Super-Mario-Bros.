using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class SpinningCoinSprite : AnimatedSprite
    {

        protected override Vector2 FrameSource => SpriteUtility.spinCoinFrameSource;
        protected override float FrameOffset => SpriteUtility.spinCoinOffset;


        public SpinningCoinSprite(Texture2D texture) : base(texture, SpriteUtility.spinCoinFrames, SpriteUtility.spinCoinWidth, SpriteUtility.spinCoinHeight)
        {
           
        }
        public override Rectangle GetRectangle(Vector2 location)
        {
            return new Rectangle();
        }
    }

}
