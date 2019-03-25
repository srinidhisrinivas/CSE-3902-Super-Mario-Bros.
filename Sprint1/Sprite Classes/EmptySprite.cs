using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class EmptySprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => new Vector2();

        public EmptySprite(Texture2D texture) : base(texture, SpriteUtility.emptyFrames, SpriteUtility.emptyWidth, SpriteUtility.emptyHeight)
        {
        }
        public override void Update(GameTime gameTime)
        {

        }
        public override void Draw(SpriteBatch spriteBatch, Vector2 location, Color color) 
        {

        }
        public override Rectangle GetRectangle(Vector2 location)
        {
            return new Rectangle();
        }
        
    }
    

}
