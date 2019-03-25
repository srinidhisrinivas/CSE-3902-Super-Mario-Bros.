using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class IntermediateGameState : IGameState
    {
        protected Game1 game { get; set; }
        protected IList<IHUDElement> textContentList { get; }
        protected IntermediateGameState(Game1 game)
        {
            this.game = game;
            game.KeyboardController = new InactiveKeyboardController(game);
            this.textContentList = new List<IHUDElement>();
        }
        public virtual void Update(GameTime gameTime)
        {
            foreach(IHUDElement element in this.textContentList)
            {
                element.Update(gameTime);
            }
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            game.GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(); foreach (IHUDElement element in this.textContentList)
            {
                element.Draw(spriteBatch);
            }
            spriteBatch.End();

        }
    }
}
