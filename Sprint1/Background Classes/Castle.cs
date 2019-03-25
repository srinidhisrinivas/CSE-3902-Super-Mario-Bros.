using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class Castle : BackgroundObject
    {
        
        public Castle(Vector2 location) : base(location)
        {
            this.Sprite = BackgroundSpriteFactory.Instance.CreateCastleSprite();
        }
        
    }
}