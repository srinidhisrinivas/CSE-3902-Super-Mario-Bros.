using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class MediumCloud : BackgroundObject
    {
        
        public MediumCloud(Vector2 location) : base(location)
        {
            this.Sprite = BackgroundSpriteFactory.Instance.CreateMediumCloudSprite();
        }
        
    }
}