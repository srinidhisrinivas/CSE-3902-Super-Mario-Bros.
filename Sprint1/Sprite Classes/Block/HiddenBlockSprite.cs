using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class HiddenBlockSprite : AnimatedSprite
    {
        protected override Vector2 FrameSource => new Vector2();

        public HiddenBlockSprite(Texture2D texture) : base(texture, SpriteUtility.blockFrames, SpriteUtility.blockWidth, SpriteUtility.blockHeight)
        {
           
        }
        public override void Update(GameTime gameTime)
        {

        }
        public override void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {

        }
        
        
    }

}
