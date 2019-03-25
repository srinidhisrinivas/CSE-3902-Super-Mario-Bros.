using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandBounceFireball : ICommand
    {
        private ICollision side;
        private IProjectile projectile;
        public CommandBounceFireball(IProjectile projectile, ICollision side)
        {
            this.side = side;
            this.projectile = projectile;
        }
        public void Execute()
        {
            new CommandMoveEntityUp(projectile, side).Execute();
            projectile.Bounce();
        }
    }
}