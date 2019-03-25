using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class QuestionBlockSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => SpriteUtility.questionBlockFrameSource;
        protected override float FrameOffset => SpriteUtility.questionBlockFrameOffset;


        public QuestionBlockSprite(Texture2D texture) : base(texture, SpriteUtility.questionBlockFrames, SpriteUtility.blockWidth,SpriteUtility.blockHeight)
        {

        }
    }

}
