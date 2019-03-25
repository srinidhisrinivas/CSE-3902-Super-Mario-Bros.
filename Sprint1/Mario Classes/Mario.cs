using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class Mario : MarioPhysics, IMario
    {
        public Scoreboard Scoreboard { get; private set; }
        public int StompChain { get; set; }
        public Rectangle HitBox { get => State.HitBox; }
        public IPowerType PowerType { get; set; }
        public IMarioState State { get; set; }

        public Mario(Vector2 location) : base(location)
        {
            StompChain = MarioUtility.stompChainInit;
            Scoreboard = new Scoreboard();
            State = new SmallMarioRightIdle(this);
            PowerType = new SmallMarioType();
        }

        public virtual void Fall()
        {
            State.Fall();
        }
        public virtual void Idle()
        {
            State.Idle();
        }

        public virtual void Jump()
        {
            State.Jump();
        }
        public virtual void GoRight()
        {
            State.GoRight();
        }
        public virtual void GoLeft()
        {
            State.GoLeft();
        }
        public virtual void Crouch()
        {
            State.Crouch();
        }
        public virtual void RunRight(int time)
        {
            State.RunRight(time);
        }
        public virtual void TakeDamage()
        {
            State.TakeDamage();
        }
        
        public virtual void Die()
        {
            State.Die();
        }
        public virtual void Stand()
        {
            base.StopMotionY();
            this.StompChain = MarioUtility.stompChainInit;
            State.Stand();
        }
        public virtual void BecomeBig()
        {
            State.BecomeBig();
        }
        public virtual void BecomeFire()
        {
            State.BecomeFire();
        }

        public virtual void ShootFireball()
        {
            State.ShootFireball();
        }
        public virtual void Run()
        {
            State.Run();
        }

        public virtual void DescendFlagpole() {

            State.DescendFlagpole();
        }

        public override void Update(GameTime gameTime)
        {
            if (!(this.VerticalMotionState is IdleState))
            {
                State.Fall();
            }
            if(!(this.State is DeadMario) && this.Location.Y > MarioUtility.marioYLocation)
            {
                this.State = new DeadMario(this);
            }
            State.Update(gameTime);
            base.Update(gameTime);

        }

        public virtual void Draw(SpriteBatch spriteBatch, Color color)
        {
            State.Draw(spriteBatch, color);
        }
        public virtual void Bounce()
        {
            this.Location += MarioUtility.marioLocation;
            this.yVelocity = MarioUtility.marioYVelocity;
        }
        
    }
}
