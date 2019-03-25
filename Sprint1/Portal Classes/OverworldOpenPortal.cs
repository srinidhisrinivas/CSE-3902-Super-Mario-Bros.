using Microsoft.Xna.Framework;

namespace CSE3902
{


    public class OverworldOpenPortal : Portal
    {
        public OverworldOpenPortal(Vector2 location, int portalTag, int width, int height, Portal.MotionDirection entryFace) : base(location, portalTag, width, height, entryFace, () => LevelEditFactory.SetOverWorldConditions())
        {
            this.IsPortalActivated = true;
        }

        public override void SwitchOff()
        {

        }
    }
}