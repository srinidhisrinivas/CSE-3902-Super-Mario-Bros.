using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace CSE3902
{

    public class ExitPortal : Portal
    {
       
        public ExitPortal(Vector2 location, int portalTag, int width, int height, Portal.MotionDirection motionDir) : base(location, portalTag, width, height, motionDir)
        {

        }
        public override void SwitchOn()
        {

        }
        public override void SwitchOff()
        {

        }
        public override void GoThrough(IMario mario)
        {
            Game1.Instance.Mario = new PipeTransitionMario(mario, () => { });
            this.motionVelocityMap[this.motionDir](mario);

        }
    }
}