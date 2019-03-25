using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class QuestionBlock : Block
    {
        protected QuestionBlock(Vector2 location) : base(location)
        {
            BlockSprite = BlockSpriteFactory.Instance.CreateQuestionBlockSprite();
            this.BlockState = new BumpableBlockState(this);
        }
    }

}
