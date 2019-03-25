using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class MediumBush : BackgroundObject
    {
        public MediumBush(Vector2 location) : base(location)
        {
            this.Sprite = BackgroundSpriteFactory.Instance.CreateMediumBushSprite();
        }
    }
}