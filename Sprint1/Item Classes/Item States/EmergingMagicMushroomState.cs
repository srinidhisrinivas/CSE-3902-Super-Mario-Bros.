using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    public class EmergingMagicMushroomState : EmergingStateAbstract
    {
        public EmergingMagicMushroomState(IItem item) : base(item)
        {
            this.ItemSprite = ItemSpriteFactory.Instance.CreateMagicMushroomSprite();
            emergedItemStateType = typeof(MovingMagicMushroomState);

        }
    }
}
