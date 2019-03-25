using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class PipeSprite : ISprite
    {
        int topWidth;
        int topHeight;
        int segmentHeight;
        int segmentWidth;
        int totalHeight;
        int frameScale;
        int pipeHeight;
        private readonly Texture2D texture;


        protected PipeSprite(Texture2D texture, int pipeHeight)
        {
            segmentHeight = SpriteUtility.segmentHeightInit;
            segmentWidth = SpriteUtility.segmentWidthInit;
            this.texture = texture;
            this.topHeight = SpriteUtility.topHeightInit;
            this.topWidth = SpriteUtility.topWidthInit;
            frameScale = SpriteUtility.pipeFrameScaleInit;
            this.pipeHeight = pipeHeight;
            this.totalHeight = topHeight + (pipeHeight - 1) * segmentHeight;
        }

        public virtual void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {
            if (spriteBatch == null)
            {
                throw new ArgumentNullException("spriteBatch");
            }
            Vector2 topFrameSource = SpriteUtility.topFrameSource;
            Vector2 topLocation = new Vector2(location.X, location.Y - frameScale * (totalHeight - topHeight));
            float frameX = topFrameSource.X;
            float frameY = topFrameSource.Y;
            Vector2 drawLocation = new Vector2(topLocation.X, topLocation.Y);
            Rectangle source = new Rectangle((int)frameX, (int)frameY, topWidth, topHeight);
            spriteBatch.Draw(texture, drawLocation, source, color, SpriteUtility.rotation, new Vector2(SpriteUtility.xOrigin, topHeight), frameScale, SpriteEffects.None, SpriteUtility.layerDepth); ;

            for (int segment = 0; segment < pipeHeight; segment++)
            {
                Vector2 segmentLocation = new Vector2(location.X + frameScale * 2.0f, location.Y - segment * frameScale * segmentHeight);
                Vector2 segmentSource = SpriteUtility.segmentFrameSource;
                drawLocation = new Vector2(segmentLocation.X, segmentLocation.Y);
                source = new Rectangle((int)segmentSource.X, (int)segmentSource.Y, segmentWidth, segmentHeight);
                spriteBatch.Draw(texture, drawLocation, source, color, SpriteUtility.rotation, new Vector2(SpriteUtility.xOrigin, segmentHeight), frameScale, SpriteEffects.None, SpriteUtility.layerDepth); ;
            }
        }
        public virtual Rectangle GetRectangle(Vector2 location)
        {
            return new Rectangle((int)location.X, (int)location.Y - frameScale * totalHeight, frameScale * topWidth, frameScale * totalHeight);
        }

        public virtual void Update(GameTime gameTime)
        {

        }


    }
}
