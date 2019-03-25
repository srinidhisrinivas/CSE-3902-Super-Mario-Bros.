using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class TransitionMarioState : MarioState
    {
        protected int StateTimer { get; set; }
        private bool drawDestinationSprite;
        protected Dictionary<bool, ISprite> CurrentSpriteMap { get; }
        protected IMarioState FinalState {get; set;}
        protected TransitionMarioState(IMario mario) : base(mario)
        {
            CurrentSpriteMap = new Dictionary<bool, ISprite>();
            StateTimer = MarioUtility.transitionMarioStateTimer;
            drawDestinationSprite = false;
            Mario.StopMotionX();
        }
        public override void Crouch()
        {

        }
        public override void Jump()
        {

        }
        public override void GoLeft()
        {

        }
        public override void GoRight()
        {

        }
        public override void Die()
        {

        }
        public override void Update(GameTime gameTime)
        {
            StateTimer--;
            if (StateTimer == MarioUtility.stateTimerZero)
            {
                Mario.State = FinalState;
            }
            else
            {
                MarioSprite.Update(gameTime);
            }
            if (StateTimer % MarioUtility.transitionMarioSpriteFrames == MarioUtility.zero)
            {
                drawDestinationSprite = !drawDestinationSprite;
                MarioSprite = CurrentSpriteMap[drawDestinationSprite];
            }
           
        }
        public override void Draw(SpriteBatch spriteBatch, Color color)
        {
            MarioSprite.Draw(spriteBatch, Mario.Location, color);
        }

    }
}
