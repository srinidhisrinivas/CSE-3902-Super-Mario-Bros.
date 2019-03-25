using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class LittleHill : BackgroundObject
    {
        
        public LittleHill(Vector2 location) : base(location)
        {

            this.Sprite = BackgroundSpriteFactory.Instance.CreateLittleHillSprite();
        }
       
    }
}