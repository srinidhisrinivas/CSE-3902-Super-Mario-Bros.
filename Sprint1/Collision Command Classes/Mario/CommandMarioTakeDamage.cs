using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandMarioTakeDamage : MarioCollisionCommand
    {
        
        
        public CommandMarioTakeDamage(IMario mario) : base(mario)
        {
            
        }
        public override void Execute()
        {
            if (!(mario.State is DeadMario))
            {
                SoundManager.PlaySoundEffect(SoundUtility.pipeSoundEffect);
            }
            mario.TakeDamage();
            
        }
    }
}