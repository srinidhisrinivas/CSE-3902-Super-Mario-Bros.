using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public abstract class EnemyState : IEnemyState
    {
        public Rectangle HitBox { get => EnemySprite.GetRectangle(Enemy.Location); }
        protected ISprite EnemySprite { get; set; }
        protected IEnemy Enemy { get; set; }

        protected EnemyState(IEnemy enemy)
        {
            this.Enemy = enemy;
        }

        public virtual void GetStomped()
        {

        }

        public virtual void Die()
        {

        }

        public virtual void GoLeft()
        {

        }

        public virtual void GoRight()
        {

        }

        public virtual void Update(GameTime gameTime)
        {
            EnemySprite.Update(gameTime);
        }

        public virtual void Draw(SpriteBatch spriteBatch, Color color)
        {
            EnemySprite.Draw(spriteBatch, Enemy.Location, color);
        }
    }
}
