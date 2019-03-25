using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class LittleBush : BackgroundObject
    {

        public LittleBush(Vector2 location) : base(location)
        {
       
            this.Sprite = BackgroundSpriteFactory.Instance.CreateLittleBushSprite();
        }
        
    }
}