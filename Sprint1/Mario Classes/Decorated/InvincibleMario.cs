using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class InvincibleMario : DecoratedMario
    {

        public InvincibleMario(IMario decoratedMario) : base(decoratedMario)
        {
            this.decoratorTimer = MarioUtility.decoratorTimer;
        }
        
        public override void TakeDamage()
        {

        }
        
       
        public override void Draw(SpriteBatch spriteBatch, Color color)
        {
            decoratedMario.Draw(spriteBatch, decoratorTimer % MarioUtility.invincibleMarioSpriteFrames == MarioUtility.zero ? Color.Transparent : Color.White);
           
        }

    }
}