using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{
    public class DisappearingFloatingText : HUDElement
    {
        
        private int disappearTimer;
        public DisappearingFloatingText(ITextContent textContent, Vector2 location) : base(textContent, location)
        {
            this.font = FontFactory.Instance.CreatePointFont();
            this.disappearTimer = ScoreUtility.disappearTimerInit;
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            this.Location -= ScoreUtility.disappearTextLocation;
            if(disappearTimer-- == ScoreUtility.disappearTimerMin)
            {
                LevelEditFactory.RemoveHUDElement(this);
            }
        }
        
    }
}