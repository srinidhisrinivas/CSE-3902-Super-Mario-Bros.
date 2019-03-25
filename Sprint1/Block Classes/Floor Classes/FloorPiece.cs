using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class FloorPiece : IFloorPiece
    {
        public Rectangle HitBox => new Rectangle((int)this.location.X, (int)this.location.Y - floorHeight * blockHeight, floorWidth * blockWidth, floorHeight * blockHeight);
        private IList<IBlock> listOfFloorBlocks;
        private Vector2 location;
        private int blockWidth;
        private int blockHeight;
        private int floorWidth;
        private int floorHeight;
        private Type blockType;
        public FloorPiece(Vector2 location, int floorWidth, int floorHeight, Type blockType)
        {
            this.location = location;
            this.floorWidth = floorWidth;
            this.floorHeight = floorHeight;
            this.blockType = blockType;

            this.blockWidth = SpriteUtility.scaledBlockWidth;
            this.blockHeight = SpriteUtility.scaledBlockHeight;

            this.listOfFloorBlocks = new List<IBlock>();
            this.InitializeFloor();
           
        }
        private void InitializeFloor()
        {
            for (int i = 0; i < this.floorWidth; i++)
            {
                for (int j = 0; j < this.floorHeight; j++)
                {
                    this.listOfFloorBlocks.Add((IBlock)Activator.CreateInstance(blockType, new Vector2(location.X + i * blockWidth, location.Y - j * blockHeight)));
                }
            }
        }
        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            foreach(IBlock block in this.listOfFloorBlocks)
            {
                block.Draw(spriteBatch, color);
            }
        }
        public void Update(GameTime gameTime)
        {

        }
    }
}
