using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class Projectile : UniversalPhysics, IProjectile
    {
        public IMario ProjectileSource { get; protected set; }
        public Rectangle HitBox { get => ProjectileState.HitBox; }
        public IProjectileState ProjectileState { get; set; }
        protected Projectile(Vector2 location) : this(location, null)
        {
        }
        
        protected Projectile(Vector2 location, IMario projectileSource) : base(location)
        {
            this.ProjectileSource = projectileSource;
        }
        public virtual void Draw(SpriteBatch spriteBatch, Color color)
        {
            ProjectileState.Draw(spriteBatch, color);
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            ProjectileState.Update(gameTime);
        }
        public virtual void Destroy()
        {
            ProjectileState.Destroy();
        }
        public virtual void Bounce()
        {

        }
    }
}
