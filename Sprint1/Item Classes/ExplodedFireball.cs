using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class ExplodedFireball : ItemStateAbstract
    {
        public ExplodedFireball(IItem item) : base(item)
        {
            Item.ItemSprite = ItemSpriteFactory.Instance.CreateInactiveFireballSprite();
        }
       
    }
}
