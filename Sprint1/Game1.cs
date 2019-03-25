using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;

namespace CSE3902
{

    public class Game1 : Game
    {
        readonly GraphicsDeviceManager graphics;

        SpriteBatch spriteBatch;
        public string levelFile { get; set; }
        private string originalLevelFile;
        private Dictionary<GameStates, Type> gameStateMap;
        public enum GameStates { Active, Paused, GameOver, Win, Reset, Magic};
        public IList<IHUDElement> gameHUDElements { get; private set; }
        public IController KeyboardController { get; set; }
        
        public Level Level { get; private set; }
        public Vector2 ScreenDimensions { get; private set; }
        public IGameState GameState { get; set; }
        

        public IMario Mario { get; set; }

        public static Game1 Instance { get; } = new Game1();
       
        private Game1()
        {
            gameHUDElements = new List<IHUDElement>();
            gameStateMap = new Dictionary<GameStates, Type>();

            gameStateMap.Add(GameStates.Active, typeof(ActiveGameState));
            gameStateMap.Add(GameStates.Paused, typeof(PausedGameState));
            gameStateMap.Add(GameStates.GameOver, typeof(GameoverGameState));
            gameStateMap.Add(GameStates.Win, typeof(WinningGameState));
            gameStateMap.Add(GameStates.Reset, typeof(LevelResetGameState));
            gameStateMap.Add(GameStates.Magic, typeof(MagicGameState));


            ScreenDimensions = ScoreUtility.screenDim;
            //Change this to "Level Files\level-1-1.xml" for level 1-1.
            this.originalLevelFile = @"Level Files\level-1-1.xml";
            
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = ScoreUtility.contentName;
            
        }


        protected override void Initialize()
        {
            
            this.Mario = new Mario(new Vector2());
            this.Mario.Scoreboard.AddLives(3);

            this.levelFile = this.originalLevelFile;

            this.ReloadLevel();
            this.ResetMarioState();


            this.ChangeGameState(Game1.GameStates.Reset);

            base.Initialize();

        }


        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            gameHUDElements.Clear();

            gameHUDElements.Add(new HeaderText(new StringDisplay(() => { return ScoreUtility.scoreText; }), ScoreUtility.scoreTextLocation));
            gameHUDElements.Add(new HeaderText(new StringDisplay(() => { return ScoreUtility.coinText; }), ScoreUtility.coinTextLocation));
            gameHUDElements.Add(new HeaderText(new StringDisplay(() => { return ScoreUtility.timeText; }), ScoreUtility.timeTextLocation));
            gameHUDElements.Add(new HeaderText(new StringDisplay(() => { return ScoreUtility.worldText; }), ScoreUtility.worldTextLocation));

            gameHUDElements.Add(new HeaderText(new StringDisplay(() => { return this.Level.WorldNum; }), ScoreUtility.worldNumLocation));
            gameHUDElements.Add(new HeaderText(new NumericDisplay(() => { return this.Mario.Scoreboard.PointCount; }), ScoreUtility.scoreNumLocation));
            gameHUDElements.Add(new HeaderText(new NumericDisplay(() => { return this.Mario.Scoreboard.CoinCount; }), ScoreUtility.coinNumLocation));
            gameHUDElements.Add(new HeaderText(new NumericDisplay(() => { return this.Level.LevelTimer.RemainingTime; }), ScoreUtility.timeNumLocation));



        }
        public void ResetMarioState()
        {
            Mario.State = new SmallMarioRightIdle(Mario);
        }
        public void ReloadLevel()
        {
            this.Level = new Level(levelFile, ScreenDimensions);
            this.Level.LoadLevel(Content);
            this.ChangeGameState(GameStates.Active);
        }
        public void ResetGame()
        {
            this.Initialize();
        }
        public void ChangeGameState(Game1.GameStates newGameState)
        {
            this.GameState = (IGameState)Activator.CreateInstance(gameStateMap[newGameState], this);
        }
        protected override void UnloadContent()
        {

        }


        protected override void Update(GameTime gameTime)
        {
            KeyboardController.Update(gameTime);
            GameState.Update(gameTime);
            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GameState.Draw(spriteBatch);
            spriteBatch.Begin();
            foreach (IHUDElement element in this.gameHUDElements)
            {
                element.Draw(spriteBatch);
            }
            spriteBatch.End();
            base.Draw(gameTime);
            
        }
    }
}
