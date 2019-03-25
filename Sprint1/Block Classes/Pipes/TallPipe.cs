using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class TallPipe : Pipe
    {
        public TallPipe(Vector2 location) : base(location)
        {
            BlockSprite = BlockSpriteFactory.Instance.CreateTallPipeSprite(); 
        }

    }
}