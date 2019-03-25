using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class Pipe : Block
    {
        protected Pipe(Vector2 location) : base(location)
        {
            this.BlockState = new RigidBlockState(this);
        }
        public override void PerformAction()
        {

        }
    }
}
