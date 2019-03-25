using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class DamageTransitionState : TransitionMarioState
    {
        
        protected DamageTransitionState(IMario mario) : base(mario)
        {
            
        }
       
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (StateTimer == 0)
            {
                Game1.Instance.Mario = new InvincibleMario(Mario);
            }
            
        }

    }
}
