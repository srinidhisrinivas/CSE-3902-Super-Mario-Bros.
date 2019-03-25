using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class MarioPhysics : UniversalPhysics
    {
        private float rightMaxVelocity;
        private float leftMaxVelocity;
        protected MarioPhysics(Vector2 location) : base(location)
        {
            rightMaxVelocity = PhysicsUtility.marioRightMaxVelocity;
            leftMaxVelocity = PhysicsUtility.marioLeftMaxVelocity;
        }
        public override void Update(GameTime gameTime)
        {
            if(Game1.Instance.GameState is MagicGameState)
            {
                rightMaxVelocity = 2.0f;
                leftMaxVelocity = -2.0f;
            }
            else
            {
                rightMaxVelocity = PhysicsUtility.marioRightMaxVelocity;
                leftMaxVelocity = PhysicsUtility.marioLeftMaxVelocity;
            }
            if (this.xVelocity > rightMaxVelocity)
            {
                this.xVelocity = rightMaxVelocity;
            }
            if (this.xVelocity < leftMaxVelocity)
            {
                this.xVelocity = leftMaxVelocity;
            }
            base.Update(gameTime);
            if (this.VerticalMotionState is FallingState)
            {
                this.ResetGravity();
            }

        }
    }
}
