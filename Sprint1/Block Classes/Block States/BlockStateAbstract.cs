using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class BlockStateAbstract : IBlockState
    {
        protected IBlock Block { get; set; }
        protected BlockStateAbstract(IBlock block)
        {
            this.Block = block;
        }

        public virtual void Draw(SpriteBatch spriteBatch, Color color)
        {

        }
        public virtual void GetBroken()
        {
            Block.BlockState = new BrokenBlock(Block);
        }
        public virtual void GetBumped()
        {
            
            Block.BlockState = new BumpedUsedBlock(Block);
        }

        
        public virtual void Update(GameTime gameTime)
        {
            
        }
    }
}
