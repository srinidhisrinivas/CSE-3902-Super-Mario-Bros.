using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class MarioState :IMarioState
    {
        public Rectangle HitBox { get => MarioSprite.GetRectangle(Mario.Location); }
        protected ISprite MarioSprite { get; set; }
        protected IMario Mario { get; set; }
        protected MarioState(IMario mario)
        {
            this.Mario = mario;
        }
        protected void JumpingLeftMotion()
        {
            Mario.Location -= MarioUtility.jumpingMarioDisplacement;
        }
        protected void JumpingRightMotion()
        {
            Mario.Location += MarioUtility.jumpingMarioDisplacement;
        }
        public virtual void RunRight(int time)
        {

        }
        public virtual void TakeDamage()
        {

        }
        public virtual void Run()
        {
            Mario.xVelocity *= MarioUtility.runningVelocityFactor;
        }
        public virtual void Fall()
        {

        }
        public virtual void Idle()
        {

        }
        public virtual void Jump()
        {

        }
        public virtual void ResetXVelocity()
        {
            Mario.xVelocity /= MarioUtility.runningVelocityFactor;
           
        }
        public virtual void GoLeft()
        {
            this.Mario.xVelocity = MarioUtility.marioLeftXVelocity;
        }
        public virtual void GoRight()
        {
            this.Mario.xVelocity = MarioUtility.marioRightXVelocity;
        }
        public virtual void Crouch()
        {

        }
        public virtual void BecomeBig()
        {

        }
        public virtual void Stand()
        {

        }
        public virtual void BecomeFire()
        {

        }
        public virtual void DescendFlagpole() {


        }
        public virtual void ShootFireball()
        {

        }
        public virtual void Die()
        {
            Mario.State = new DeadMario(Mario);
        }
        public virtual void Update(GameTime gameTime)
        {
            MarioSprite.Update(gameTime);
        }
        public virtual void Draw(SpriteBatch spriteBatch, Color color)
        {
            MarioSprite.Draw(spriteBatch, Mario.Location, color);
        }
    }

}
