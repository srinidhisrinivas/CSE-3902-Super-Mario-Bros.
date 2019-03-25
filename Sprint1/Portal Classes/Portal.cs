using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace CSE3902
{
   
    public abstract class Portal : IPortal
    {
        
        public enum MotionDirection { Up, Down, Left, Right };
        public bool IsPortalActivated { get; protected set; }
        public Vector2 Location { get; set; }
        public Rectangle HitBox => new Rectangle((int)Location.X, (int)Location.Y, width, height);
        public IPortal LinkedPortal { get; set; }
        public int PortalTag { get; protected set; }

        protected Portal.MotionDirection motionDir { get; set; }
        protected OnPassageEvent passageEvent { get; set; }
        protected float motionVelocity { get; set; }
        protected int width { get; set; }
        protected int height { get; set; }
        protected Dictionary<Portal.MotionDirection, PlayerPortalEffect> motionVelocityMap { get; }
        protected Portal(Vector2 location, int portalTag, int width, int height, Portal.MotionDirection motionDir)
        {
            this.motionVelocity = 0.5f;
            this.IsPortalActivated = false;
            this.Location = location;
            this.PortalTag = portalTag;
            this.width = width;
            this.height = height;
            this.motionDir = motionDir;

            motionVelocityMap = new Dictionary<MotionDirection, PlayerPortalEffect>();

            motionVelocityMap.Add(Portal.MotionDirection.Up, (mario) => mario.yVelocity = -motionVelocity);
            motionVelocityMap.Add(Portal.MotionDirection.Down, (mario) => mario.yVelocity = motionVelocity);
            motionVelocityMap.Add(Portal.MotionDirection.Left, (mario) => mario.xVelocity = -motionVelocity);
            motionVelocityMap.Add(Portal.MotionDirection.Right, (mario) => mario.xVelocity = motionVelocity);
        }
        protected Portal(Vector2 location, int portalTag, int width, int height, Portal.MotionDirection motionDir, OnPassageEvent passageEvent) : this(location, portalTag, width, height, motionDir)        {

            this.passageEvent = passageEvent;
        }
        public virtual void GoThrough(IMario mario)
        {
            Game1.Instance.Mario = new PipeTransitionMario(mario, () => { mario.Location = this.LinkedPortal.Location;
                passageEvent();
                this.LinkedPortal.GoThrough(mario);
            });
            motionVelocityMap[this.motionDir](mario);


        }
        public virtual void SwitchOn()
        {
            IsPortalActivated = true;
        }
        public virtual void SwitchOff()
        {
            IsPortalActivated = false;
        }

    }
    

}