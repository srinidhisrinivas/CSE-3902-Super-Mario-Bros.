using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class LittleCloud : BackgroundObject
    {

        public LittleCloud(Vector2 location) : base(location)
        {

            this.Sprite = BackgroundSpriteFactory.Instance.CreateLittleCloudSprite();
        }
    }
}