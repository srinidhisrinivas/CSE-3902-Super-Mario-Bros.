using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class MovingMushroomStateAbstract : ItemStateAbstract
    {
        protected MovingMushroomStateAbstract(IItem item) : base(item)
        {
            Item.xVelocity = 2f;
        }      
    }
}
