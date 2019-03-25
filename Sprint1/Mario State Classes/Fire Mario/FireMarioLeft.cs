using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class FireMarioLeft : FireMarioState
    {
        protected FireMarioLeft(IMario mario) : base(mario)
        {

        }
        public override void Fall()
        {
            Mario.State = new FireMarioLeftJump(Mario);
        }
        public override void Idle()
        {
            Mario.State = new FireMarioLeftIdle(Mario);

        }
        public override void TakeDamage()
        {
            Mario.State = new FireToBigMarioLeft(Mario);
        }
    }
}
