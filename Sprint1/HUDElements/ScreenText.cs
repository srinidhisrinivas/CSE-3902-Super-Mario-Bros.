using Microsoft.Xna.Framework;

namespace CSE3902
{
    class ScreenText : HUDElement
    {
        public ScreenText(ITextContent textContent, Vector2 location) : base(textContent, location)
        {
            this.font = FontFactory.Instance.CreateScreenTextFont();
        }

    }
}