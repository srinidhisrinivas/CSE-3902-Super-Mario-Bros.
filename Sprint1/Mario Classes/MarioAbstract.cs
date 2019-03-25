using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class MarioAbstract
    {
        public enum MovementState { Run, Jump, Idle, Crouch };
        /*
        public void UpdateAction(IMario mario)
        {
            Thread.Sleep(100);
            if (mario.GetState() == MarioAbstract.MovementState.Jump)
            {
                mario.Jump();
            }
            if (mario.GetState() == MarioAbstract.MovementState.Idle)
            {
                mario.Idle();
            }
            if (mario.GetState() == MarioAbstract.MovementState.Crouch)
            {
                mario.Crouch();
            }
            if (mario.GetState() == MarioAbstract.MovementState.Run)
            {
                mario.Run();
            }
        }
        */

    }
}
