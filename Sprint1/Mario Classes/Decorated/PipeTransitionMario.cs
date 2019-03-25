using Microsoft.Xna.Framework;

namespace CSE3902
{
    public class PipeTransitionMario : DecoratedMario
    {
        private OnUnwrapEvent unwrapEvent;
        public override Rectangle HitBox => new Rectangle(); 
        public PipeTransitionMario(IMario decoratedMario, OnUnwrapEvent unwrapEvent) : base(decoratedMario)
        {
            this.StopMotionX();
            this.StopMotionY();
            this.yAcceleration = MarioUtility.pipeTransitionMarioYAcceleration;
            this.unwrapEvent = unwrapEvent;
            this.decoratorTimer = MarioUtility.pipeTransitionMariodecoratorTimer;
        }
        public override void BecomeBig()
        {

        }
        public override void BecomeFire()
        {

        }

        public override void Bounce()
        {

        }
        public override void ResetGravity()
        {

        }
        public override void Fall()
        {
           
        }
        public override void GoLeft()
        {

        }
        public override void GoRight()
        {

        }
        public override void TakeDamage()
        {
            
        }
        public override void Stand()
        {

        }
        public override void ShootFireball()
        {

        }
        public override void Run()
        {
            
        }
        public override void Die()
        {

        }
        public override void Jump()
        {

        }
        public override void Crouch()
        {
           
        }
        public override void Idle()
        {

        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if(decoratorTimer == MarioUtility.timerElapse)
            {
                this.StopMotionY();
                decoratedMario.Idle();
                decoratedMario.Stand();
                decoratedMario.ResetGravity();
                this.unwrapEvent();
            }
        }

    }
}