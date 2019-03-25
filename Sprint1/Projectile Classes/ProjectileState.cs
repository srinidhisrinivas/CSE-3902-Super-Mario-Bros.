using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class ProjectileState : IProjectileState
    {
        public Rectangle HitBox { get => ProjectileSprite.GetRectangle(Projectile.Location); }
        protected IProjectile Projectile { get; }
        protected ISprite ProjectileSprite { get; set; }
        protected ProjectileState(IProjectile projectile)
        {
            this.Projectile = projectile;
        }
        public virtual void Update(GameTime gameTime)
        {
            ProjectileSprite.Update(gameTime);
        }
        public virtual void Draw(SpriteBatch spriteBatch, Color color)
        {
            ProjectileSprite.Draw(spriteBatch, Projectile.Location, color);
        }
        public virtual void Destroy()
        {
            LevelEditFactory.RemoveProjectile(Projectile);
        }
        public virtual void Bounce()
        {

        }
    }
}
