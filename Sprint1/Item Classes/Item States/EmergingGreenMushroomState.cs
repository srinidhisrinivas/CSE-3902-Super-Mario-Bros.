using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    public class EmergingGreenMushroomState : EmergingStateAbstract
    {
        public EmergingGreenMushroomState(IItem item) : base(item)
        {
            this.ItemSprite = ItemSpriteFactory.Instance.CreateGreenMushroomSprite();
            emergedItemStateType = typeof(MovingGreenMushroomState);

        }

    }
}
