using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class BigMarioRight : BigMarioState
    {
        protected BigMarioRight(IMario mario) : base(mario)
        {

        }
        public override void Fall()
        {
            Mario.State = new BigMarioRightJump(Mario);
        }
        public override void Idle()
        {
            Mario.State = new BigMarioRightIdle(Mario);

        }
        public override void TakeDamage()
        {
            Mario.State = new BigToSmallMarioRight(Mario);
        }
    }
}
