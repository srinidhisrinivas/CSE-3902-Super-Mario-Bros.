
namespace CSE3902
{
    public class CommandGoThroughPortal: ICommand
    {
        private IMario mario;
        private IPortal portal;
        public CommandGoThroughPortal(IMario mario, IPortal portal)
        {
            this.mario = mario;
            this.portal = portal;
        }
        public void Execute()
        {
            if (portal.IsPortalActivated)
            {
                SoundManager.PlaySoundEffect(SoundUtility.pipeSoundEffect);
                portal.GoThrough(mario);
            }
        }
    }
}