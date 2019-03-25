using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class Bridge : IBridge, IFloorPiece
    {
        public Rectangle HitBox => new Rectangle((int)this.Location.X, (int)this.Location.Y - 2 * 16, this.length * 2 * 4, 2 * 16);
        public Vector2 Location { get; set; }
        private int length;
        private int segmentRetractMSTimeStep;
        private int previousTimeStamp;
        private bool retracted;
        private ISprite linkSprite;
        public Bridge(Vector2 location, int length)
        {
            this.previousTimeStamp = 0;
            this.Location = location;
            this.length = length;
            this.segmentRetractMSTimeStep = 25;
            this.retracted = false;
            this.linkSprite = BlockSpriteFactory.Instance.CreateBridgeLinkSprite();
        }
        public void Retract()
        {
            SoundManager.PlaySoundEffect("BowserFall");
            SoundManager.StopSong();
            this.retracted = true;
        }
        public void Update(GameTime gameTime)
        {
            if(this.previousTimeStamp == 0)
            {
                this.previousTimeStamp = (int)gameTime.TotalGameTime.TotalMilliseconds;
            }
            if (this.retracted)
            {
                int currentTimeStamp = (int)gameTime.TotalGameTime.TotalMilliseconds;
                if(currentTimeStamp - this.previousTimeStamp > this.segmentRetractMSTimeStep)
                {
                    this.length--;
                    this.previousTimeStamp = currentTimeStamp;
                }
            }
        }
        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            for(int i = 0; i < this.length; i++)
            {
                this.linkSprite.Draw(spriteBatch, new Vector2(this.Location.X + i * 2 * 4, this.Location.Y), color);
            }
        }
    }
}
