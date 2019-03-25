using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class Lava : IFloorPiece
    {
        public Vector2 Location { get; set; }
        public Rectangle HitBox => new Rectangle();
        private int width;
        private int height;
        private ISprite lavaBlockSprite;
        private ISprite lavaSurfaceSprite;
        public Lava(Vector2 location, int width, int height)
        {
            this.Location = location;
            this.width = width;
            this.height = height;
            this.lavaBlockSprite = BlockSpriteFactory.Instance.CreateLavaBlockSprite();
            this.lavaSurfaceSprite = BlockSpriteFactory.Instance.CreateLavaSurfaceSprite();
        }
        public void Update(GameTime gameTime)
        {

        }
        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            Vector2 drawLocation = this.Location;
            for(int i = 0; i < this.height; i++)
            {
                for(int j = 0; j < this.width; j++)
                {
                    this.lavaBlockSprite.Draw(spriteBatch, drawLocation, color);
                    drawLocation += new Vector2(2 * 16, 0);
                }
                drawLocation = new Vector2(this.Location.X, drawLocation.Y - 32);
            }
            for(int j = 0; j < this.width; j++)
            {
                this.lavaSurfaceSprite.Draw(spriteBatch, drawLocation, color);
                drawLocation += new Vector2(2 * 16, 0);
            }
        }

    }
}
