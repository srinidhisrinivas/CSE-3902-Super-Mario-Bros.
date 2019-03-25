using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class AnimatedSprite : ISprite
    {
        private int currentFrame;
        private int totalFrames;
        protected int FrameWidth { get; set; }
        protected int FrameHeight { get; set; }
        protected int FrameScale { get; set; }
        protected abstract Vector2 FrameSource { get; }
        protected virtual float FrameOffset => SpriteUtility.frameOffsetInit;
        protected virtual SpriteEffects SpriteEffects => SpriteEffects.None;
        private readonly Texture2D texture;


        protected AnimatedSprite(Texture2D texture, int totalFrames, int frameWidth, int frameHeight)
        {
            this.texture = texture;
            this.totalFrames = totalFrames;
            this.FrameWidth = frameWidth;
            this.FrameHeight = frameHeight;
            FrameScale = SpriteUtility.frameScaleInit;
            currentFrame = SpriteUtility.currentFrameInit;
        }

        public virtual void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {

            if (spriteBatch == null)
            {
                throw new ArgumentNullException("spriteBatch");
            }
            
            float frameX = this.FrameSource.X + this.FrameOffset * (float)currentFrame;
            float frameY = this.FrameSource.Y;
            Vector2 drawLocation = new Vector2(location.X, location.Y);
            Rectangle source = new Rectangle((int)frameX, (int)frameY, FrameWidth, FrameHeight);
            spriteBatch.Draw(texture, drawLocation, source, color, SpriteUtility.rotation, new Vector2(SpriteUtility.xOrigin, FrameHeight), FrameScale, this.SpriteEffects, SpriteUtility.layerDepth); ;

        }
        public virtual Rectangle GetRectangle(Vector2 location)
        {
            return new Rectangle((int)location.X, (int)location.Y - FrameScale * FrameHeight, FrameScale * FrameWidth, FrameScale * FrameHeight);
        }

        public virtual void Update(GameTime gameTime)
        {
            if (gameTime == null)
            {
                throw new ArgumentNullException("gameTime");
            }
            if ((int)gameTime.TotalGameTime.TotalMilliseconds % SpriteUtility.gameTimeMod == 0)
            {
                currentFrame++;
                if (currentFrame == totalFrames)
                {
                    currentFrame = currentFrame - totalFrames;
                }
            }
        }
        
    }
}
