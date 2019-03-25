using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902
{

    public class NumericDisplay : TextContent
    {
        private NumericValueGetter getNumericValue;
        public NumericDisplay(NumericValueGetter getNumericValue) : base()
        {
            this.getNumericValue = getNumericValue;
            this.Text = getNumericValue().ToString();
        }
        public override void Update(GameTime gameTime)
        {
            this.Text = getNumericValue().ToString();
        }
       
    }
}