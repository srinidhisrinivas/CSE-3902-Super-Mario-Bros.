using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandExplodeFireball : ICommand
    {
        private IProjectile projectile;
        public CommandExplodeFireball(IProjectile projectile)
        {
            this.projectile = projectile;
        }
        public void Execute()
        {
            SoundManager.PlaySoundEffect(SoundUtility.bumpSoundEffect);
            projectile.Destroy();
        }
    }
}