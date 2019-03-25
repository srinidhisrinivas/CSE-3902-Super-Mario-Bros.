using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public interface IBlockState : IBumpable, IBreakable
    {
        void Update(GameTime gameTime);
        void Draw(SpriteBatch spriteBatch, Color color);

    }
}