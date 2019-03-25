using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    public class MovingMagicMushroomState : MovingMushroomStateAbstract
    {
        public MovingMagicMushroomState(IItem item) : base(item)
        {
            this.ItemSprite = ItemSpriteFactory.Instance.CreateMagicMushroomSprite();
        }

    }
}
