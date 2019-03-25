using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace CSE3902
{
    public interface IMario : IGameObject, IRigidBody
    {
        Scoreboard Scoreboard { get; }
        IMarioState State { get; set; }

        IPowerType PowerType { get; set; }
        int StompChain { get; set; }
        void Jump();
        void Run();
        void GoLeft();

        void GoRight();

        void Crouch();
        void Stand();
        void Bounce();
        void Fall();
        void Idle();
        void BecomeBig();

        void BecomeFire();

        void Die();

        void TakeDamage();

        void ShootFireball();

        void DescendFlagpole();

        void RunRight(int time);

        void Update(GameTime gameTime);

        void Draw(SpriteBatch spriteBatch, Color color);



    }
}