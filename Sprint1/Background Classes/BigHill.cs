using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class BigHill : BackgroundObject
    {
        
        public BigHill(Vector2 location) : base(location)
        {

            this.Sprite = BackgroundSpriteFactory.Instance.CreateBigHillSprite();
        }
        
    }
}