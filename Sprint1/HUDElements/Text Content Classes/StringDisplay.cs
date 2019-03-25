using Microsoft.Xna.Framework;

namespace CSE3902
{

    public class StringDisplay : TextContent
    {
        private StringValueGetter stringGetter;
        public StringDisplay(StringValueGetter stringGetter) : base()
        {
            this.stringGetter = stringGetter;
            this.Text = stringGetter();
        }
        public override void Update(GameTime gameTime)
        {
            this.Text = stringGetter();
        }

    }
}