using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandShoot : KeyboardCommand
    {
        public CommandShoot(Game1 game) : base(game)
        {

        }
        public override void Execute()
        {
            SoundManager.PlaySoundEffect("ShootFireball");
            game.Mario.ShootFireball();
        }
    }
}
