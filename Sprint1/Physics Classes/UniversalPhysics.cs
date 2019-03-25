using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    public abstract class UniversalPhysics : IRigidBody
    {
        public Vector2 Location { get; set; }
        public IVerticalMotionState VerticalMotionState { get; set; }
        public float xVelocity { get; set; }
        public float yVelocity { get; set; }
        public float yAcceleration { get; set; }
        public float xAcceleration { get; set; }
        protected UniversalPhysics(Vector2 location)
        {
                this.Location = location;
                this.xVelocity = PhysicsUtility.xVelocity;
                this.yVelocity = PhysicsUtility.yVelocity;
                this.xAcceleration = PhysicsUtility.xAcceleration;
                this.yAcceleration = PhysicsUtility.universalGravity;
        }
        public virtual void Update(GameTime gameTime)
        {
            if(Game1.Instance.GameState is MagicGameState&&this is Mario)
            {
                this.yAcceleration = 0.15f;
            }
            if (yVelocity > PhysicsUtility.risingStateThreshold)
            {
                this.VerticalMotionState = new FallingState();
            }
            else if (yVelocity < PhysicsUtility.fallingStateThreshold)
            {
                this.VerticalMotionState = new RisingState();
            }
            else
            {
                this.VerticalMotionState = new IdleState();
            }
            this.Location += new Vector2(this.xVelocity, this.yVelocity);
            this.xVelocity += this.xAcceleration;
            this.yVelocity += this.yAcceleration;
           
        }
        public void StopMotionX()
        {
            this.xVelocity = PhysicsUtility.xVelocity;
        }
        public void StopMotionY()
        {
            this.yVelocity = PhysicsUtility.yVelocity;
        }
        public virtual void ResetGravity()
        {
            this.yAcceleration = PhysicsUtility.universalGravity;
        }
        public virtual void SuspendGravity()
        {
            this.yAcceleration = PhysicsUtility.suspendedGravity;
        }
    }

}
