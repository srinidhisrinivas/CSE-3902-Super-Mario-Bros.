using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class FireMarioRight : FireMarioState
    {
        protected FireMarioRight(IMario mario) : base(mario)
        {

        }
        public override void Fall()
        {
            Mario.State = new FireMarioRightJump(Mario);
        }
        public override void Idle()
        {
            Mario.State = new FireMarioRightIdle(Mario);

        }
        public override void TakeDamage()
        {
            Mario.State = new FireToBigMarioRight(Mario);
        }
    }
}
