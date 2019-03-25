namespace CSE3902
{
    public interface IPortal : ICollidable, ILocateable
    {
        bool IsPortalActivated { get; }
        int PortalTag { get; }
        IPortal LinkedPortal { get; set; }
        void GoThrough(IMario mario);
        void SwitchOn();
        void SwitchOff();
    }
}