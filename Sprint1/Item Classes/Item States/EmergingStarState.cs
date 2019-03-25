using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    public class EmergingStarState : EmergingStateAbstract
    {
        public EmergingStarState(IItem item) : base(item)
        {
            this.ItemSprite = ItemSpriteFactory.Instance.CreateStarSprite();
            emergedItemStateType = typeof(BouncyStarState);

        }

    }
}
