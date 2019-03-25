using Microsoft.Xna.Framework;

namespace CSE3902
{
    class HorizontalMovingPlatform : Block
    {
        private float initVelocity;
        private int range;
        private Vector2 initLocation;
        public HorizontalMovingPlatform(Vector2 location) : base(location)
        {
            this.BlockState = new RigidBlockState(this);
            this.BlockSprite = BlockSpriteFactory.Instance.CreatePlatformSprite();
            this.initLocation = location;
            this.initVelocity = BlockUtility.platformInitialVelocity;
            this.xVelocity = this.initVelocity;
            this.range = BlockUtility.platformRange;
        }
        public override void Update(GameTime gameTime)
        {
            if((this.xVelocity > BlockUtility.zeroCheck && this.Location.X >= this.initLocation.X + range) || (this.xVelocity < BlockUtility.zeroCheck && this.Location.X <= initLocation.X))
            {
                this.ChangeDirection();
            }
            base.Update(gameTime);
        }
        private void ChangeDirection()
        {
            this.xVelocity *= BlockUtility.platformChangeDirectrion;
        }
    }
}