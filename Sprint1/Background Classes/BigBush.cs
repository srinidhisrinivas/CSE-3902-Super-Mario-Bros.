using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class BigBush : BackgroundObject
    {
        public BigBush(Vector2 location) : base(location)
        {
            this.Sprite = BackgroundSpriteFactory.Instance.CreateBigBushSprite();
        }
    }
}