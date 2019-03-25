using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class BumpedBrickBlock : BumpedBlock
    {


        public BumpedBrickBlock(IBlock block) : base(block, block.BlockState.GetType())
        {


        }


    }
}
