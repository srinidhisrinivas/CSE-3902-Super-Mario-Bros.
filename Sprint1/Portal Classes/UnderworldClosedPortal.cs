using Microsoft.Xna.Framework;

namespace CSE3902
{

    public class UnderworldClosedPortal : Portal
    {
        public UnderworldClosedPortal(Vector2 location, int portalTag, int width, int height, Portal.MotionDirection entryFace) : base(location, portalTag, width, height, entryFace, () => LevelEditFactory.SetUnderWorldConditions())
        {

        }
    }
}