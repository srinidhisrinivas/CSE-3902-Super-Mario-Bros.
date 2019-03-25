using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class Enemy : UniversalPhysics, IEnemy
    {
        public IEnemyState State { get; set; }
        public virtual Rectangle HitBox  => State.HitBox; 

        protected Enemy(Vector2 location) : base(location)
        {

        }




        public virtual void Draw(SpriteBatch spriteBatch, Color color)
        {
            State.Draw(spriteBatch, Color.White);
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            State.Update(gameTime);
            if(this.Location.Y > ScoreUtility.screenDim.Y)
            {
                LevelEditFactory.RemoveEnemy(this);
            }
        }

        public virtual void Die(OnDeathActions onDeathAction)
        {
            onDeathAction();
            State.Die();
        }
        public virtual void TakeDamage(OnDeathActions onDeathActions)
        {
            this.Die(onDeathActions);
        }
        public void GetStomped()
        {
            State.GetStomped();
        }

        public void GoLeft()
        {
            State.GoLeft();
        }

        public void GoRight()
        {
            State.GoRight();
        }
    }
}
