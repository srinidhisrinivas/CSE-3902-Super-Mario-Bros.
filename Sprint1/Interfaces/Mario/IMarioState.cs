using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public interface IMarioState : ICollidable
    {
        void Jump();
        void GoLeft();
        void GoRight();
        void Crouch();
        void BecomeBig();
        void Run();
        void ResetXVelocity();
        void BecomeFire();
        void TakeDamage();
        void Die();
        void Stand();
        void Fall();
        void Idle();
        void ShootFireball();
        void DescendFlagpole();
        void RunRight(int time);
        void Update(GameTime gameTime);
        void Draw(SpriteBatch spriteBatch, Color color);
    }
}
