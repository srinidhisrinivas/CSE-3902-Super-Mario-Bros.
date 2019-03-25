using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class HiddenBlockCoin : Block
    {
        public HiddenBlockCoin(Vector2 location) : base(location)
        {
            this.PowerUp = new Coin(this.Location);
            this.BlockState = new BumpableBlockState(this);
            BlockSprite = BlockSpriteFactory.Instance.CreateHiddenBlockSprite(); 
        }
        
       
    }
}