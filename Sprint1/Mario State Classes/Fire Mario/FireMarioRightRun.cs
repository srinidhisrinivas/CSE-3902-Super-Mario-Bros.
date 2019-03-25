using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class FireMarioRightRun : FireMarioRight
    {

        public FireMarioRightRun(IMario mario) : base(mario)
        {
            MarioSprite = MarioSpriteFactory.Instance.CreateFireMarioRightRunSprite();
        }
       
        public override void Jump()
        {
            base.Jump();
            Mario.State = new FireMarioRightJump(Mario);
        }
        public override void GoLeft()
        {
            Mario.State = new FireMarioRightIdle(Mario);
        }
        public override void GoRight()
        {
            
        }
        public override void Crouch()
        {
            Mario.State = new FireMarioRightCrouch(Mario);
        }
       
        public override void ShootFireball()
        {
            LevelEditFactory.AddProjectile(new Fireball(Mario, Fireball.FireballDirections.Right));
        }
    }
}