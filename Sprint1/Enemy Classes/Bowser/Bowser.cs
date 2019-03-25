using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class Bowser : Enemy, IBowser
    {
        private int healthPoints;
        private BowserBrain brain;
        public Bowser(Vector2 location) : base(location)
        {
            this.brain = new BowserBrain(this);
            this.healthPoints = BlockUtility.bowserHealthPotion;
            this.State = new StationaryLeftFacingBowserState(this);
            this.yAcceleration = BlockUtility.bowserYAcceleration;
            Game1.Instance.Level.LevelSong = new CastleSong();

        }
        public void Jump()
        {
            IBowserState state = (IBowserState)State;
            state.Jump();
        }
        public void ShootFireball()
        {
            IBowserState state = (IBowserState)State;
            state.ShootFireball();
        }
        public void Idle()
        {
            IBowserState state = (IBowserState)State;
            state.Idle();
        }
        public override void TakeDamage(OnDeathActions onDeathAction)
        {
            this.healthPoints -= BlockUtility.bowserHealthPotionDamage;
            if (healthPoints <= BlockUtility.zeroCheck)
            {
                this.Die(onDeathAction);
            }
        }
        public override void Update(GameTime gameTime)
        {
            this.brain.Update(gameTime);
            base.Update(gameTime);
        }



    }
}