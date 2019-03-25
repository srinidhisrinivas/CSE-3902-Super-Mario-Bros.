using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class BigCloud : BackgroundObject
    {
        
        public BigCloud(Vector2 location) : base(location)
        {
            this.Sprite = BackgroundSpriteFactory.Instance.CreateBigCloudSprite();
        }
        
    }
}