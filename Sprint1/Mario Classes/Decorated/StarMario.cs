using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class StarMario : DecoratedMario
    {                
        public StarMario(IMario decoratedMario) : base(decoratedMario)
        {
            this.decoratorTimer = MarioUtility.starMariodecoratorTimer;
            
        }
        
        public override void TakeDamage()
        {

        }
       
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if(decoratorTimer == MarioUtility.timerElapse)
            {
                Game1.Instance.Level.LevelSong.Unwrap();
            }
        }

        public override void Draw(SpriteBatch spriteBatch, Color color)
        {
            decoratedMario.Draw(spriteBatch, decoratorTimer % MarioUtility.starMarioreminder == MarioUtility.zero ? Color.Blue : Color.Yellow);
            
        }
        
    }
}
