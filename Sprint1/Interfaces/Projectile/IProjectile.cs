using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{ 
    public interface IProjectile : IGameObject, IRigidBody
    {
        IProjectileState ProjectileState { get; set; }
        IMario ProjectileSource { get; }
        void Update(GameTime gameTime);
        void Draw(SpriteBatch spriteBatch, Color color);
        void Destroy();
        void Bounce();
    }
}
