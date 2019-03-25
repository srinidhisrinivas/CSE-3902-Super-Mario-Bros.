using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class BrickBlock : IBlock,IRectangleable
    {
        IBlockState blockState;
        Vector2 location;
        public BrickBlock(Vector2 location)
        {
            this.location = location;
            blockState = new BrickBlockState(location);
        }
        public void PerformAction()
        {
            blockState = new HiddenBlockState(location);
        }
        public void Reset()
        {
            blockState = new BrickBlockState(location);
        }
        public Rectangle GetRectangle()
        {
            return blockState.GetRectangle();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            blockState.Draw(spriteBatch);
        }
        public void Update(GameTime gameTime)
        {
            blockState.Update(gameTime);
        }
    }
}