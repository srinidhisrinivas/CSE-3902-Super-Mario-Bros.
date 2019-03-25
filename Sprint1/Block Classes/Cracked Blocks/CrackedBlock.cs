using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class CrackedBlock : Block
    {
        protected CrackedBlock(Vector2 location) : base(location)
        {
            this.BlockState = new RigidBlockState(this);
        }
       
        public override void PerformAction()
        {

        }


    }
}