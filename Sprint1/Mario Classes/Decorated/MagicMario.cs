using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class MagicMario : DecoratedMario
    {
        int i = MarioUtility.timerElapse;
        Color randColor = Color.Wheat;
        public MagicMario(IMario decoratedMario) : base(decoratedMario)
        {
            this.decoratorTimer = MarioUtility.magicMariodecoratorTimer;

        }

        public override void TakeDamage()
        {

        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (decoratorTimer == MarioUtility.timerElapse)
            {
                Game1.Instance.Level.LevelSong.Unwrap();

                Game1.Instance.ChangeGameState(Game1.GameStates.Active);
                if (Game1.Instance.Level.isUnderworld)
                {
                    Game1.Instance.Level.SetUnderWorldConditions();
                }
            }
            else if(this.State is DeadMario)
            {
                this.RemoveDecorator();
            }
        }

        public override void Draw(SpriteBatch spriteBatch, Color color)
        {
            if (i % 30 == MarioUtility.timerElapse)
            {
                Random r = new Random();
                randColor = new Color(
                     (byte)r.Next(MarioUtility.minColor, MarioUtility.maxColor),
                     (byte)r.Next(MarioUtility.minColor, MarioUtility.maxColor),
                     (byte)r.Next(MarioUtility.minColor, MarioUtility.maxColor)
                     );
            }
            i++;
            decoratedMario.Draw(spriteBatch, randColor);

        }

    }
}
