using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class BigMarioLeft : BigMarioState
    {
        protected BigMarioLeft(IMario mario) : base(mario)
        {

        }
        public override void Fall()
        {
            Mario.State = new BigMarioLeftJump(Mario);
        }
        public override void Idle()
        {
            Mario.State = new BigMarioLeftIdle(Mario);

        }
        public override void TakeDamage()
        {
            Mario.State = new BigToSmallMarioLeft(Mario);
        }
    }
}
