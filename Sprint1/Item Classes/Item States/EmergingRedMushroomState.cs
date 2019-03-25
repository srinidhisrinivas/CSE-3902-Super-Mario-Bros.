using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    public class EmergingRedMushroomState : EmergingStateAbstract
    {
        public EmergingRedMushroomState(IItem item) : base(item)
        {
            this.ItemSprite = ItemSpriteFactory.Instance.CreateRedMushroomSprite();
            emergedItemStateType = typeof(MovingRedMushroomState);

        }
    }
}
