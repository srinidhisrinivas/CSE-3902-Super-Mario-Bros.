using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public interface IRigidBody : ILocateable
    {
        IVerticalMotionState VerticalMotionState { get; set; }
        float xVelocity { get; set; }
        float yVelocity { get; set; }
        float yAcceleration { get; set; }
        float xAcceleration { get; set; }
        void StopMotionX();
        void StopMotionY();
        void ResetGravity();
    }
}
