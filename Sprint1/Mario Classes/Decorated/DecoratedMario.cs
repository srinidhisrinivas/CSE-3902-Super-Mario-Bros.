using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class DecoratedMario : IMario
    {

        protected IMario decoratedMario { get; set; }
        protected int decoratorTimer { get; set; }
        public int StompChain { get => decoratedMario.StompChain; set => decoratedMario.StompChain = value; }
        public Scoreboard Scoreboard { get => decoratedMario.Scoreboard; }
        public virtual Rectangle HitBox { get => decoratedMario.HitBox; }
        public Vector2 Location { get => decoratedMario.Location; set => decoratedMario.Location = value; }
        public float yAcceleration { get => decoratedMario.yAcceleration; set => decoratedMario.yAcceleration = value; }
        public IVerticalMotionState VerticalMotionState { get => decoratedMario.VerticalMotionState; set => decoratedMario.VerticalMotionState = value; }
        public float yVelocity { get => decoratedMario.yVelocity; set => decoratedMario.yVelocity = value; }
        public float xVelocity { get => decoratedMario.xVelocity; set => decoratedMario.xVelocity = value; }
        public float xAcceleration { get => decoratedMario.xAcceleration; set => decoratedMario.xAcceleration = value; }

        public virtual IMarioState State { get => decoratedMario.State; set => decoratedMario.State = value; }
        public virtual IPowerType PowerType { get => decoratedMario.PowerType; set => decoratedMario.PowerType = value; }


        protected DecoratedMario(IMario decoratedMario)
        {
            this.decoratedMario = decoratedMario;
        }
        public virtual void ResetGravity()
        {
            decoratedMario.ResetGravity();
        }
        public virtual void Run()
        {
            decoratedMario.Run();
        }
        public virtual void RunRight(int time)
        {
            decoratedMario.RunRight(time);
        }
        public virtual void Idle()
        {
            decoratedMario.Idle();
        }
        public virtual void Fall()
        {
            decoratedMario.Fall();
        }
        public virtual void Bounce()
        {
            decoratedMario.Bounce();
        }
        public void StopMotionX()
        {
            decoratedMario.StopMotionX();
        }
        public void StopMotionY()
        {
            decoratedMario.StopMotionY();
        }
        public virtual void TakeDamage()
        {
            decoratedMario.TakeDamage();
        }
        public virtual void Stand()
        {
            decoratedMario.Stand();
        }
        public virtual void DescendFlagpole() {
            decoratedMario.DescendFlagpole();
        }

        public virtual void Update(GameTime gameTime)
        {
            decoratorTimer--;
            if (decoratorTimer == MarioUtility.timerElapse)
            {
                RemoveDecorator();
            }

            decoratedMario.Update(gameTime);
        }

        public void RemoveDecorator()
        {
            Game1.Instance.Mario = decoratedMario;
        }


        public virtual void Jump()
        {
            decoratedMario.Jump();
        }
        public virtual void GoRight()
        {
            decoratedMario.GoRight();
        }
        public virtual void GoLeft()
        {
            decoratedMario.GoLeft();
        }
        public virtual void Crouch()
        {
            decoratedMario.Crouch();
        }

        public virtual void BecomeBig()
        {
            decoratedMario.BecomeBig();
        }
        public virtual void BecomeFire()
        {
            decoratedMario.BecomeFire();
        }

        public virtual void Die()
        {
            decoratedMario.Die();
        }
        public virtual void ShootFireball()
        {
            decoratedMario.ShootFireball();
        }
        public virtual void Draw(SpriteBatch spriteBatch, Color color)
        {
            decoratedMario.Draw(spriteBatch, color);

        }

    }
}