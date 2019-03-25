//MagicGameState
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class MagicGameState : IGameState
    {
        private Game1 game;
        int i = BlockUtility.zeroCheck;
        Color randColor1 = Color.White;
        Color randColor2 = Color.White;
        Color randColor3 = Color.White;
        Color randColor4 = Color.White;
        public MagicGameState(Game1 game)
        {
            SoundManager.ResumeSong();
            this.game = game;
            game.Level.SetMagicConditions();
            game.KeyboardController = new InvertedKeyboardController(game);

        }
        public void Update(GameTime gameTime)
        {
            game.Level.Update(gameTime);
            foreach (IHUDElement element in game.gameHUDElements)
            {
                element.Update(gameTime);
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (i% BlockUtility.fifty == BlockUtility.zeroCheck) {
                    Random r = new Random();
                     randColor1 = new Color(
                         (byte)r.Next(BlockUtility.zeroCheck, BlockUtility.next255),
                         (byte)r.Next(BlockUtility.zeroCheck, BlockUtility.next255),
                         (byte)r.Next(BlockUtility.zeroCheck, BlockUtility.next255)
                         );
                     randColor2 = new Color(
                        (byte)r.Next(BlockUtility.zeroCheck, BlockUtility.next255),
                        (byte)r.Next(BlockUtility.zeroCheck, BlockUtility.next255),
                        (byte)r.Next(BlockUtility.zeroCheck, BlockUtility.next255)
                        );
                    randColor3 = new Color(
                        (byte)r.Next(BlockUtility.zeroCheck, BlockUtility.next255),
                        (byte)r.Next(BlockUtility.zeroCheck, BlockUtility.next255),
                        (byte)r.Next(BlockUtility.zeroCheck, BlockUtility.next255)
                        );
                randColor4 = new Color(
                        (byte)r.Next(BlockUtility.zeroCheck, BlockUtility.next255),
                        (byte)r.Next(BlockUtility.zeroCheck, BlockUtility.next255),
                        (byte)r.Next(BlockUtility.zeroCheck, BlockUtility.next255)
                        );
                                }
            i++;
            game.Level.Draw(spriteBatch, game.GraphicsDevice,randColor1, randColor2,randColor3,randColor4);

        }
    }
}
