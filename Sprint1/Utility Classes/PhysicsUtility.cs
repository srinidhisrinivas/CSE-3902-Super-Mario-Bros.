using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public static class PhysicsUtility
    {
        public readonly static float xVelocity = 0f;

        public readonly static float yVelocity = 0f;

        public readonly static float xAcceleration = 0f;

        public readonly static float universalGravity = 1f;

        public readonly static float fallingStateThreshold = -1f;

        public readonly static float risingStateThreshold = 1f;

        public readonly static float marioRightMaxVelocity = 4.8f;

        public readonly static float marioLeftMaxVelocity = -4.8f;

        public readonly static float enemySlideVelocity = -5f;

        public readonly static float suspendedGravity = 0f;

    }
}
