﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class LeftPipe : Pipe
    {
        public LeftPipe(Vector2 location) : base(location)
        {

            BlockSprite = BlockSpriteFactory.Instance.CreateLeftPipeSprite(); 
        }
        

    }
}