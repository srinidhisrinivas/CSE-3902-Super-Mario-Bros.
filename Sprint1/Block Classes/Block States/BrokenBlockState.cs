using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class BrokenBlockState : BlockStateAbstract
    {
        private Brick.BrickColor brickColor;

        private IProjectile topLeftBrick;
        private IProjectile topRightBrick;
        private IProjectile bottomLeftBrick;
        private IProjectile bottomRightBrick;

        private float screenYLimit;
        private IBlock brokenBlock;
        public BrokenBlockState(IBlock block) : base(block)
        {
            if (block.GetType().Name.StartsWith("Blue"))
            {
                brickColor = Brick.BrickColor.Blue;
            } else
            {
                brickColor = Brick.BrickColor.Red;
            }
            Block.BlockSprite = BlockSpriteFactory.Instance.CreateEmptySprite();

            topLeftBrick = new Brick(new Vector2(block.Location.X, block.Location.Y - BlockUtility.brickOffset), Brick.BrickType.Left, brickColor, BlockUtility.topBrickLeftVelocity, BlockUtility.topBrickYVelocity);
            topRightBrick = new Brick(new Vector2(block.Location.X + BlockUtility.brickOffset, block.Location.Y - BlockUtility.brickOffset), Brick.BrickType.Right, brickColor, BlockUtility.topBrickRightVelocity, BlockUtility.topBrickYVelocity);
            bottomLeftBrick = new Brick(new Vector2(block.Location.X, block.Location.Y), Brick.BrickType.Left, brickColor, BlockUtility.bottomBrickLeftVelocity, BlockUtility.bottomBrickYVelocity);
            bottomRightBrick = new Brick(new Vector2(block.Location.X + BlockUtility.brickOffset, block.Location.Y), Brick.BrickType.Right, brickColor, BlockUtility.bottomBrickRightVelocity, BlockUtility.bottomBrickYVelocity);          
            
            this.brokenBlock = block;
            screenYLimit = MarioUtility.screenYLimit;

        }
        public override void Update(GameTime gameTime)
        {
             
            topLeftBrick.Update(gameTime);
            topRightBrick.Update(gameTime);
            bottomLeftBrick.Update(gameTime);
            bottomRightBrick.Update(gameTime);
            if (topLeftBrick.Location.Y > screenYLimit)
            {
                LevelEditFactory.RemoveBlock(this.brokenBlock);
                LevelEditFactory.RemoveProjectile(topLeftBrick);
                LevelEditFactory.RemoveProjectile(topRightBrick);
                LevelEditFactory.RemoveProjectile(bottomLeftBrick);
                LevelEditFactory.RemoveProjectile(bottomRightBrick);

            } 
        }
        
        public override void GetBumped()
        {

        }
        public override void Draw(SpriteBatch spriteBatch, Color color)
        {
            topLeftBrick.Draw(spriteBatch, Color.White);
            topRightBrick.Draw(spriteBatch, Color.White);
            bottomLeftBrick.Draw(spriteBatch, Color.White);
            bottomRightBrick.Draw(spriteBatch, Color.White);
        }

    }
}
