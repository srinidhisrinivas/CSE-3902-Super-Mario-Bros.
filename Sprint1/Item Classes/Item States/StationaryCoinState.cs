using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    public class StationaryCoinState : ItemStateAbstract
    {
        public StationaryCoinState(IItem item) : base(item)
        {
            Item.yAcceleration = PhysicsUtility.suspendedGravity;
            this.ItemSprite = ItemSpriteFactory.Instance.CreateStationaryCoinSprite();


        }
        
    }
}
