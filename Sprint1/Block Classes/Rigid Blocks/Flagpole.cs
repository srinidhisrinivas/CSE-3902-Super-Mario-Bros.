using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class Flagpole : Block
    {
        protected IProjectile projectile { get; set; }
        public Flagpole(Vector2 location) : base(location)
        {
            this.BlockState = new RigidBlockState(this);
            projectile = new Flag(new Vector2(this.Location.X - BlockUtility.flagWidth, this.Location.Y - BlockUtility.flagpoleHeight));
            LevelEditFactory.AddProjectile(projectile);
            BlockSprite = BlockSpriteFactory.Instance.CreateFlagpoleSprite(); 
        }
        public override void PerformAction()
        {
            projectile.ProjectileState = new FallingWhiteFlagState(projectile);
        }

    }
}