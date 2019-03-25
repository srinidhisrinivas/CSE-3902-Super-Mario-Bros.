using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class RedBrickBlockCoin : BrickBlockCoin
    {
        public RedBrickBlockCoin(Vector2 location) : base(location)
        {
            
            BlockSprite = BlockSpriteFactory.Instance.CreateRedBrickBlockSprite();
        }

        

    }
}