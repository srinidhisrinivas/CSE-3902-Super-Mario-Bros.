using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace CSE3902
{

    public class PortalManager
    {
        public IList<IPortal> ListOfGamePortals { get; private set; }
        public PortalManager()
        {
            this.ListOfGamePortals = new List<IPortal>();
        }
        public void LinkUpPortals()
        {
            foreach (IPortal portal in ListOfGamePortals)
            {
                int currentPortalTag = portal.PortalTag;
                foreach (IPortal buddyPortal in ListOfGamePortals)
                {
                    if (buddyPortal != portal & buddyPortal.PortalTag == currentPortalTag)
                    {
                        portal.LinkedPortal = buddyPortal;
                    }
                }
            }
        }
        public void RemovePortal(IPortal portal)
        {
            this.ListOfGamePortals.Remove(portal);
        }
        public void ClearList()
        {
            this.ListOfGamePortals.Clear();
        }
        public void SwitchOnAllPortals()
        {
            foreach (IPortal portal in this.ListOfGamePortals)
            {
                portal.SwitchOn();
            }
        }
        public void SwitchOffAllPortals()
        {
            foreach (IPortal portal in this.ListOfGamePortals)
            {
                portal.SwitchOff();
            }
        }
        public void SwitchOnNearestPortal(Vector2 location)
        {
            IPortal nearestPortal = this.ListOfGamePortals[0];
            float shortestDistance = Vector2.Distance(location, nearestPortal.Location);

            foreach (IPortal portal in this.ListOfGamePortals)
            {
                float currentDistance = Vector2.Distance(location, portal.Location);
                if (currentDistance < shortestDistance)
                {
                    shortestDistance = currentDistance;
                    nearestPortal = portal;
                }
            }
            nearestPortal.SwitchOn();
        }
    }
}