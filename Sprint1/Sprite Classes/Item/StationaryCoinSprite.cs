using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class StationaryCoinSprite : AnimatedSprite
    {

        protected override Vector2 FrameSource => SpriteUtility.stationCoinFrameSource;
        protected override float FrameOffset => SpriteUtility.stationCoinOffset;

        public StationaryCoinSprite(Texture2D texture) : base(texture, SpriteUtility.stationCoinFrames, SpriteUtility.stationCoinWidth, SpriteUtility.stationCoinHeight)
        {
           
        }
        
    }

}
