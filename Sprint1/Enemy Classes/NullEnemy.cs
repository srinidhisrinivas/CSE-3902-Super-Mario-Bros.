using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class NullEnemy : Enemy
    {
        public override Rectangle HitBox { get => new Rectangle(); }
        public NullEnemy(Vector2 location) : base(location)
        {

        }

        public override void Draw(SpriteBatch spriteBatch, Color color)
        {
        }


        public override void Update(GameTime gameTime)
        {
        }
    }
}
