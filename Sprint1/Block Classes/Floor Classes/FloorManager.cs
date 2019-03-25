using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class FloorManager
    {
        public IList<IFloorPiece> ListOfFloorPieces { get; }

        public FloorManager()
        {
            this.ListOfFloorPieces = new List<IFloorPiece>();
        }
        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            foreach(IFloorPiece floorPiece in this.ListOfFloorPieces)
            {
                floorPiece.Draw(spriteBatch, color);
            }
        }
        public void Update(GameTime gameTime)
        {
            foreach(IFloorPiece floorPiece in this.ListOfFloorPieces)
            {
                floorPiece.Update(gameTime);
            }
        }
        public void RetractBridges()
        {
            foreach(IFloorPiece floorPiece in this.ListOfFloorPieces)
            {
                if(floorPiece is Bridge)
                {
                    IBridge bridge = (IBridge)floorPiece;
                    bridge.Retract();
                }
            }
        }
    }
}
