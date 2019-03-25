using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class FireMarioLeftRun : FireMarioLeft
    {

        public FireMarioLeftRun(IMario mario) : base(mario)
        {
            MarioSprite = MarioSpriteFactory.Instance.CreateFireMarioLeftRunSprite();
        }

        public override void Jump()
        {
            base.Jump();
            Mario.State = new FireMarioLeftJump(Mario);
        }
        public override void GoRight()
        {
            Mario.State = new FireMarioLeftIdle(Mario);
        }
        public override void GoLeft()
        {

        }
        public override void Crouch()
        {
            Mario.State = new FireMarioLeftCrouch(Mario);
        }
       
        public override void ShootFireball()
        {
            LevelEditFactory.AddProjectile(new Fireball(Mario, Fireball.FireballDirections.Left));
        }
    }
}